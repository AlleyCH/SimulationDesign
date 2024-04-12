using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunManager : MonoBehaviour
{
    public RocketshipHealth hp;
    public int damage = 100;
    // Define the scale factor (1 Unity unit represents 1 million kilometers)

     void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            hp.TakeDamage(damage);
            Debug.Log("yOU'VE dIED~");
        }
    }
}
