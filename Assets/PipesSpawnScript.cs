using UnityEngine;

public class PipesSpawnScript : MonoBehaviour
{
    public GameObject pipePrefab;
    public float spawnInterval = 2f;
    public float timeSinceLastSpawn = 0f;
    public float pipeOffset = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnPipes();
    }

    // Update is called once per frame
    void Update()
    {
        if (timeSinceLastSpawn >= spawnInterval)
        {
            SpawnPipes();
            timeSinceLastSpawn = 0f;
        }
        else
        {
            timeSinceLastSpawn += Time.deltaTime;
        }
    }

    void SpawnPipes()
    {
        float newPipesY = Random.Range(-pipeOffset + transform.position.y, pipeOffset + transform.position.y);

        Instantiate(pipePrefab, new Vector3(transform.position.x, newPipesY, 0), transform.rotation);
    }
}
