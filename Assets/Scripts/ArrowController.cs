using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    public Transform player; // Reference to the player's transform
    public Transform target; // Reference to the probe deployment location

    void Update()
    {
        // Calculate direction vector from player to target
        Vector3 direction = target.position - player.position;

        // Calculate rotation angle from direction vector
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // Apply rotation to arrow UI element
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}
