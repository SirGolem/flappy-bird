using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab;
    public float spawnRate = 2f;
    public float offset = 10f;

    private float timer = 0f;

    private void Start()
    {
        SpawnPipe();
    }

    private void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
            return;
        }

        SpawnPipe();
        timer = 0f;
    }

    private void SpawnPipe()
    {
        float lowestPoint = transform.position.y - offset;
        float highestPoint = transform.position.y + offset;

        Instantiate(pipePrefab, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), transform.position.z), transform.rotation);
    }
}