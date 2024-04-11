using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcidRainBoundary : MonoBehaviour
{
    public float minYPosition = -3; // Minimum Y-coordinate allowed
    public float maxYPosition = 3; // Maximum Y-coordinate allowed

    private void Update()
    {
        Vector3 currentPosition = transform.position;

        // Clamp the Y-coordinate within the specified range
        currentPosition.y = Mathf.Clamp(currentPosition.y, minYPosition, maxYPosition);

        // Update the player's position
        transform.position = currentPosition;
    }
}
