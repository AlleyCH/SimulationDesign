using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Border : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Check if the collider is tagged as particles
        if (other.CompareTag("Radiation"))
        {
            // Destroy the particle GameObject
            Destroy(other.gameObject);
        }
    }
}
