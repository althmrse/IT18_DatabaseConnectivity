using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject cactusPrefab;

    [Header("Spawn Randomness")]
    public float minSpawnDistance = 8f; // Minimum space between cacti
    public float maxSpawnDistance = 16f; // Maximum space between cacti

    private float timer = 0f;
    private float currentSpawnDelay = 0f;
    private GameManager gm;

    void Start()
    {
        gm = FindAnyObjectByType<GameManager>();
        ScheduleNextSpawn();
    }

    void Update()
    {
        // Only spawn if the game is actively playing
        if (gm != null && gm.isGameActive)
        {
            timer += Time.deltaTime;

            if (timer >= currentSpawnDelay)
            {
                Instantiate(cactusPrefab, transform.position, Quaternion.identity);
                ScheduleNextSpawn();
            }
        }
        else
        {
            timer = 0f;
        }
    }

    void ScheduleNextSpawn()
    {
        timer = 0f;
        if (gm != null && gm.currentWorldSpeed > 0)
        {
            // The formula Time = Distance / Speed ensures gaps remain fair at any speed
            float randomDistance = Random.Range(minSpawnDistance, maxSpawnDistance);
            currentSpawnDelay = randomDistance / gm.currentWorldSpeed;
        }
    }
}