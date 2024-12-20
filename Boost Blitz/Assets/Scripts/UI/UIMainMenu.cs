using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIMainMenu : MonoBehaviour
{
    [SerializeField] Button _startSplitScreen;
    [SerializeField] Button _startSinglePlayer;
    [SerializeField] Button _Quit;
   

   public void Start()
   {
    _startSplitScreen.onClick.AddListener(startSplitScreen);
    _startSinglePlayer.onClick.AddListener(startSinglePlayer);
    _Quit.onClick.AddListener(QuitGame);
   }

   private void startSplitScreen()
   {
    ScenesManager.Instance.LoadScene(ScenesManager.Scene.Multiplayer);
   }
   private void QuitGame()
   {
        Application.Quit();
   }
   private void startSinglePlayer()
   {
     ScenesManager.Instance.LoadScene(ScenesManager.Scene.SinglePlayer);
   }
}
