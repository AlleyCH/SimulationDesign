using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcidRainSpawner : MonoBehaviour
{
    public RocketshipHealth hp;
    public GameObject acid;
    public AcidRainSpawner[] spawners;
    public float initialSpawnRate = 1f; // Initial rate at which acid rain spawns (in seconds)
    public int minSpeed;
    public int maxSpeed;
    public float duration = 60f;
    public float minSpawnRate = 0.5f; // Minimum spawn rate of acid rain
    public float spawnYPosition = 10f; // Y position where acid rain spawns
    public int damage = 25;
    private float nextSpawnTime;
    private float timer;
    private float spawnRate;

    // Start is called before the first frame update
    private void Start()
    {
        timer = duration;
        spawnRate = initialSpawnRate;
        InvokeRepeating("SpawnAcidRain", 0f, spawnRate);
    }

    private void Update()
    {
        if (Time.time >= nextSpawnTime)
        {
            foreach (var spawner in spawners)
            {
                spawner.SpawnAcidRain();
            }
            nextSpawnTime = Time.time + 1.0f / spawnRate;
        }
    }

    private void SpawnAcidRain()
    {
        // Calculate a random horizontal position within the screen bounds
        float randomXPosition = Random.Range(Camera.main.ScreenToWorldPoint(Vector3.zero).x, Camera.main.ScreenToWorldPoint(Vector3.right * Screen.width).x);

        // Instantiate the acid rain object at the spawn position
        GameObject acidPrefab = Instantiate(acid, new Vector3(randomXPosition, spawnYPosition, 0f), Quaternion.identity);

        // Set a random speed for the acid rain object
        float randomSpeed = Random.Range(0.5f * maxSpeed, maxSpeed);
        acidPrefab.GetComponent<Rigidbody>().velocity = new Vector2(0f, -randomSpeed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            hp.TakeDamage(damage);
        }
    }
}
