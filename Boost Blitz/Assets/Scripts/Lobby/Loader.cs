using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public static class Loader{
        public static void LoadNetwork(string scene)
        {
            NetworkManager.Singleton.SceneManager.LoadScene(scene,LoadSceneMode.Single);
        }
}