using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
   [SerializeField] Button _startSplitScreen;
   [SerializeField] Button _startMultiplayerLobby;

   void Start()
   {
    _startSplitScreen.onClick.AddListener(startSplitScreen);
    _startMultiplayerLobby.onClick.AddListener(startMultiplayerLobby);
   }

   private void startSplitScreen()
   {
    ScenesManager.Instance.LoadScene(ScenesManager.Scene.splitScreen);
   }

   private void startMultiplayerLobby()
   {
    ScenesManager.Instance.LoadScene(ScenesManager.Scene.Lobby);
   }
}
