using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1RVC : MonoBehaviour
{
    public Camera rearViewCamera;
    private bool isEnabled;
    // Start is called before the first frame update
    void Start()
    {
        isEnabled = false;
        rearViewCamera.depth = -2;
    }

    // Update is called once per frame
    void Update()
    {

        ToggleCamera();
    }

    void ToggleCamera()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (isEnabled)
            {
                isEnabled = false;
                rearViewCamera.depth = -2;
            }
            else
            {
                isEnabled = true;
                rearViewCamera.depth = 1;
            }
        }
    }
}
