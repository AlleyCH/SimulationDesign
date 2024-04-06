using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetController : MonoBehaviour
{
    public GameObject factWindow;
    public GameObject playerRocketship;

    bool isPlayerNearby = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Cursor.lockState = CursorLockMode.None; // Unlock the cursor
            Cursor.visible = true;

            // Show the fact window
            factWindow.SetActive(true);
            isPlayerNearby = true;

            // Disable spaceship movement
            if (playerRocketship != null)
            {
                RocketshipController spaceshipController = playerRocketship.GetComponent<RocketshipController>();
                if (spaceshipController != null)
                {
                    spaceshipController.enabled = false;
                }
            }
        }
    }

    //void OnTriggerExit(Collider other)
    //{
    //    if (other.CompareTag("Player"))
    //    {
    //        // Hide the fact window
    //        factWindow.SetActive(false);
    //        isPlayerNearby = false;

    //        // Enable spaceship movement
    //        if (playerRocketship != null)
    //        {
    //            RocketshipController spaceshipController = playerRocketship.GetComponent<RocketshipController>();
    //            if (spaceshipController != null)
    //            {
    //                spaceshipController.enabled = true;
    //            }
    //        }
    //    }
    //}
}
