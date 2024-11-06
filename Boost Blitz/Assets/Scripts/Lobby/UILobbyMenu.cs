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
using UnityEngine.UI;

public class UILobbyMenu : MonoBehaviour
{
    [SerializeField] Button _CreateLobby;
    [SerializeField] Button _JoinLobby;
    

    void Awake()
    {
        _CreateLobby.onClick.AddListener(CreateGame);
        _JoinLobby.onClick.AddListener(JoinGame);
    }

    async void CreateGame()
    {
        await Multiplayer.Instance.CreateLobby();
        //The host has to change the scene
        Loader.LoadNetwork("OnlineMP");
    }

    async void JoinGame()
    {
        await Multiplayer.Instance.QuickJoinLobby();
    }
}
