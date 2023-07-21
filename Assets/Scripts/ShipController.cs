using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    public float speed = 5f;
    public float swayAmount = 0.5f;
    public GameObject cannonPrefab;
    public Transform cannonSpawnPoint;
    public GameObject playerPrefab;
    public Transform playerSpawnPoint;

    private bool isPlayerOnShip = true;
    private PlayerController playerController;
    private CannonController cannonController;

    void Start()
    {
        playerController = GetComponent<PlayerController>();
        cannonController = GetComponent<CannonController>();
    }

    void Update()
    {
        // Ship movement
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        transform.position += new Vector3(horizontalInput, 0, verticalInput) * (speed * Time.deltaTime);

        // Ship swaying
        transform.rotation = Quaternion.Euler(0, 0, Mathf.Sin(Time.time) * swayAmount);

        // Cannon attack
        if (Input.GetKeyDown(KeyCode.Space))
        {
            cannonController.Fire(cannonPrefab, cannonSpawnPoint);
        }

        // Player disembark
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (isPlayerOnShip)
            {
                playerController.Disembark(playerPrefab, playerSpawnPoint);
                isPlayerOnShip = false;
            }
        }
    }
}

