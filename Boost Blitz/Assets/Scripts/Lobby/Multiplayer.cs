using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Unity.Netcode;
using Unity.Netcode.Transports.UTP;
using Unity.Networking.Transport.Relay;
using Unity.Services.Authentication;
using Unity.Services.Core;
using Unity.Services.Lobbies;
using Unity.Services.Lobbies.Models;
using Unity.Services.Relay;
using Unity.Services.Relay.Models;
using UnityEngine;
using Utilities;



public enum EncryptionType
{
    DTLS,
    WSS
}

public class Multiplayer : MonoBehaviour
{
    [SerializeField] string lobbyName = "Lobby";
    [SerializeField] int maxPlayers = 4;
    [SerializeField] EncryptionType encryption = EncryptionType.DTLS;

    public static Multiplayer Instance { get; private set; }

    Lobby currentLobby;

    EncryptionType encryptionType = EncryptionType.DTLS;
    string connectionType => encryptionType == EncryptionType.DTLS ? k_dtlsEncryption : k_wssEncryption;

    const float k_lobbyHeartbeatInterval = 20f;
    const float k_lobbyPollInterval = 65f;
    const string k_keyJoinCode = "RelayJoinCode";

    const string k_dtlsEncryption = "dtls";
    const string k_wssEncryption = "wss";

    CountdownTimer heartbeatTimer = new CountdownTimer(k_lobbyHeartbeatInterval);
    CountdownTimer pollForUpdatesTimer = new CountdownTimer(k_lobbyPollInterval);

    async void Start()
    {
        Instance = this;
        DontDestroyOnLoad(this);

        await Authenticate();

        heartbeatTimer.OnTimerStop += async () =>
        {
            await HandleHeartbeatAsync();
            heartbeatTimer.Start();
        };

        pollForUpdatesTimer.OnTimerStop += async () =>
        {
            await HandlePollForUpdatesAsync();
            pollForUpdatesTimer.Start();
        };
    }

    async Task Authenticate()
    {
        await Authenticate("Player" + Random.Range(0, 1000));
    }

    async Task Authenticate(string playerName)
    {
        if (UnityServices.State == ServicesInitializationState.Uninitialized)
        {
            InitializationOptions options = new InitializationOptions();
            options.SetProfile(playerName);

            await UnityServices.InitializeAsync(options);
        }

        AuthenticationService.Instance.SignedIn += () =>
        {
            Debug.Log("Signed in as " + AuthenticationService.Instance.PlayerId);
        };

        if (!AuthenticationService.Instance.IsSignedIn)
        {
            await AuthenticationService.Instance.SignInAnonymouslyAsync();
        }
    }

    public async Task CreateLobby()
    {
        try
        {
            Allocation allocation = await AllocationRelay();
            string relayJoinCode = await GetRelayJoinCode(allocation);

            CreateLobbyOptions options = new CreateLobbyOptions
            {
                IsPrivate = false,
                Data = new Dictionary<string, DataObject>
                {
                    { k_keyJoinCode, new DataObject(DataObject.VisibilityOptions.Member, relayJoinCode) }
                }
            };

            currentLobby = await LobbyService.Instance.CreateLobbyAsync(lobbyName, maxPlayers, options);
            Debug.Log("Created lobby: " + currentLobby.Name + " with code " + currentLobby.LobbyCode);

            // Heartbeat and poll for updates
            heartbeatTimer.Start();
            pollForUpdatesTimer.Start();
        }
        catch (LobbyServiceException e)
        {
            Debug.LogError("Failed to create lobby: " + e.Message);
        }
    }

    public async Task QuickJoinLobby()
    {
        try
        {
            currentLobby = await LobbyService.Instance.QuickJoinLobbyAsync();
            pollForUpdatesTimer.Start();

            string relayJoinCode = currentLobby.Data[k_keyJoinCode].Value;
            JoinAllocation joinAllocation = await JoinRelay(relayJoinCode);

            NetworkManager.Singleton.GetComponent<UnityTransport>().SetRelayServerData(new RelayServerData(
                joinAllocation, connectionType));

            NetworkManager.Singleton.StartClient();
        }
        catch (LobbyServiceException e)
        {
            Debug.LogError("Failed to quick join lobby: " + e.Message);
        }
    }

    async Task<Allocation> AllocationRelay()
    {
        try
        {
            return await RelayService.Instance.CreateAllocationAsync(maxPlayers - 1);
        }
        catch (RelayServiceException e)
        {
            Debug.LogError("Failed to allocate relay: " + e.Message);
            return default;
        }
    }

    async Task<string> GetRelayJoinCode(Allocation allocation)
    {
        try
        {
            return await RelayService.Instance.GetJoinCodeAsync(allocation.AllocationId);
        }
        catch (RelayServiceException e)
        {
            Debug.LogError("Failed to get relay join code: " + e.Message);
            return default;
        }
    }

    async Task<JoinAllocation> JoinRelay(string relayJoinCode)
    {
        try
        {
            return await RelayService.Instance.JoinAllocationAsync(relayJoinCode);
        }
        catch (RelayServiceException e)
        {
            Debug.LogError("Failed to join relay: " + e.Message);
            return default;
        }
    }

    async Task HandleHeartbeatAsync()
    {
        try
        {
            await LobbyService.Instance.SendHeartbeatPingAsync(currentLobby.Id);
        }
        catch (LobbyServiceException e)
        {
            Debug.LogError("Failed to heartbeat lobby " + e.Message);
        }
    }

    async Task HandlePollForUpdatesAsync()
    {
        try
        {
            currentLobby = await LobbyService.Instance.GetLobbyAsync(currentLobby.Id);
            Debug.Log("Polled for updates on lobby " + currentLobby.Name);
        }
        catch (LobbyServiceException e)
        {
            Debug.LogError("Failed to poll for updates on lobby: " + e.Message);
        }
    }
}
