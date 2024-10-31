using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoccerBallSpotLight : MonoBehaviour
{
    // Get the light from the user
    public Light spotLight;
    private Quaternion ogSpotLightRotation;
    // Start is called before the first frame update
    void Start()
    {
        ogSpotLightRotation = spotLight.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        spotLight.transform.rotation = ogSpotLightRotation;
    }
}
