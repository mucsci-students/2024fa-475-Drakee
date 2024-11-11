using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Boost : MonoBehaviour
{
    public GameObject boostFlames;
    public GameManager gameManager;
    private Rigidbody playerRigidbody;
    private bool isBoosting = false;
    private float boostDuration = 3.0f;
    private float boostCooldown = 5.0f;
    private float boostSpeed = 10.0f;
    private float boostTimer = 0.0f;
    private float cooldownTimer = 0.0f;
    private GUIStyle BoostReadyStyle;
    private GUIStyle BoostCooldownStyle;
    private GUIStyle WhileBoostingStyle;

    // Start is called before the first frame update
    void Start()
    {
        isBoosting = false;
        boostTimer = 0.0f;
        cooldownTimer = 0.0f;
        playerRigidbody = GetComponent<Rigidbody>();
        // stop rendering the boost flames
        boostFlames.SetActive(false);

        BoostReadyStyle = new GUIStyle();
        BoostReadyStyle.fontSize = 50;
        // Set the background to green
        Texture2D greenTexture = new Texture2D(1, 1);
        greenTexture.SetPixel(0, 0, Color.green);
        greenTexture.Apply();
        BoostReadyStyle.normal.background = greenTexture;

        BoostCooldownStyle = new GUIStyle();
        BoostCooldownStyle.fontSize = 50;
        // Set the background to red
        Texture2D redTexture = new Texture2D(1, 1);
        redTexture.SetPixel(0, 0, Color.red);
        redTexture.Apply();
        BoostCooldownStyle.normal.background = redTexture;

        WhileBoostingStyle = new GUIStyle();
        WhileBoostingStyle.fontSize = 50;
        // Set the background to blue
        Texture2D blueTexture = new Texture2D(1, 1);
        blueTexture.SetPixel(0, 0, Color.blue);
        blueTexture.Apply();
        WhileBoostingStyle.normal.background = blueTexture;

    }

    // Update is called once per frame
    void Update()
    {
        CheckBoost();
        CheckForGoal();
    }

    void CheckBoost()
    {
        if (Input.GetKeyDown(KeyCode.V) && !isBoosting && cooldownTimer <= 0.0f)
        {
            isBoosting = true;
            boostFlames.SetActive(true);
            boostTimer = boostDuration;
            // apply a force to the player in the forward direction
            playerRigidbody.velocity += transform.forward * boostSpeed;
        }

        if (isBoosting)
        {
            if (boostTimer > 0.0f)
            {
                boostTimer -= Time.deltaTime;
                transform.position += transform.forward * boostSpeed * Time.deltaTime;
            }
            else
            {
                isBoosting = false;
                boostFlames.SetActive(false);
                cooldownTimer = boostCooldown;
            }
        }

        if (cooldownTimer > 0.0f)
        {
            cooldownTimer -= Time.deltaTime;
        }
    }

    void CheckForGoal()
    {
        if (gameManager.getHasScored())
        {
            isBoosting = false;
            boostFlames.SetActive(false);
            cooldownTimer = 0.0f;
        }
    }

    void OnGUI()
    {
        if (cooldownTimer > 0.0f)
        {
            GUI.Box(new Rect(10, 10, 500, 70), "Boost Cooldown: " + cooldownTimer.ToString("F2"), BoostCooldownStyle);
        }
        else if (isBoosting)
        {
            GUI.Box(new Rect(10, 10, 400, 70), "Boost Time: " + boostTimer.ToString("F2"), WhileBoostingStyle);
        }
        else
        {
            GUI.Box(new Rect(10, 10, 400, 70), "Boost Ready!", BoostReadyStyle);
        }
    }
}