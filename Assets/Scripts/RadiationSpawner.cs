using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadiationSpawner : MonoBehaviour
{
    public GameObject radiationPrefab; // Assign your prefab in the Inspector
    private RocketshipHealth hp;
    public float speed = 2f; // Adjust the speed as needed
    public float duration = 60f; // Duration in seconds
    public int damage = 25;
    public float spawnInterval = 5f; // Interval between spawns

    private float timer = 0f;

    void Start()
    {
        Instantiate(radiationPrefab, transform.position, Quaternion.identity);
        // No need to instantiate radiationPrefab here, use the one assigned in the Inspector
        hp = GetComponent<RocketshipHealth>(); // Assuming RocketshipHealth is on the same GameObject
    }

    void Update()
    {
        // Increment the timer
        timer += Time.deltaTime;

        // Check if it's time to spawn a new particle
        if (timer >= spawnInterval)
        {
            // Instantiate the radiation prefab at the spawner's position
            Instantiate(radiationPrefab, transform.position, Quaternion.identity);

            // Reset the timer
            timer = 0f;
        }


        // Move the spawner from right to left
        transform.Translate(Vector3.left * speed * Time.deltaTime);

        // Check if the duration has elapsed
        if (timer >= duration)
        {
            // Destroy the spawner object
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            hp.TakeDamage(damage);
        }
    }
}
