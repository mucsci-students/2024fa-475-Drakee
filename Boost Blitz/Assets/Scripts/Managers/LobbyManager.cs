using System.Collections;
using System.Collections.Generic;
using Unity.Services.Authentication;
using Unity.Services.Core;
using Unity.Services.Lobbies;
using Unity.Services.Lobbies.Models;
using UnityEngine;

public class LobbyManager : MonoBehaviour
{
    private async void Start(){
        await UnityServices.InitializeAsync();

        AuthenticationService.Instance.SignedIn += () => {
            Debug.Log("Signed in " + AuthenticationService.Instance.PlayerId);
        };
    
        await AuthenticationService.Instance.SignInAnonymouslyAsync();
    }

    private async void CreateLobby(){
       try{
        string lobbyName = "MyLobby";
        int maxPlayers = 2;
        Lobby lobby = await LobbyService.Instance.CreateLobbyAsync(lobbyName,maxPlayers);

        Debug.Log("Created Lobby! " + lobby.Name + " " + lobby.MaxPlayers);
       }catch(LobbyServiceException e){
        Debug.Log(e);
       } 
       
    }
}

