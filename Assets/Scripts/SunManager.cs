using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunManager : MonoBehaviour
{
    // Define the scale factor (1 Unity unit represents 1 million kilometers)
    float scaleFactor = 1000000f;

    void Start()
    {
        // Radius of Earth in kilometers
        float radiusOfEarthInKm = 6371f;

        // Convert the radius from kilometers to Unity units
        float radiusOfEarthInUnityUnits = radiusOfEarthInKm / scaleFactor;

        // Set the scale of the sun GameObject
        transform.localScale = new Vector3(100, 100, 100);
    }
}
