using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SunDeath : MonoBehaviour
{
    [SerializeField] UnityEvent onCollisionEnter;

    private void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.tag == "Player")
        {
            

        }
    }
}