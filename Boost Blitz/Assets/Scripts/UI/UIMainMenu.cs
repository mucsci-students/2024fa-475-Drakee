using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
   [SerializeField] Button _startSplitScreen;

   void Start()
   {
    _startSplitScreen.onClick.AddListener(startSplitScreen);
   }

   private void startSplitScreen()
   {
    ScenesManager.Instance.LoadScene(ScenesManager.Scene.splitScreen);
   }
}
