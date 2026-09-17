using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private GameManager gm;

    void Start()
    {
        // Find the GameManager when the cactus spawns
        gm = FindAnyObjectByType<GameManager>();
    }

    void Update()
    {
        if (gm == null) return;

        // Move left at the live, constantly increasing speed
        transform.Translate(Vector3.left * gm.currentWorldSpeed * Time.deltaTime);

        if (transform.position.x < -15f)
        {
            Destroy(gameObject);
        }
    }
}