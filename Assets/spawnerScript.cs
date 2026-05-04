using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject pipePrefab;
    public float spawnRate = 2f;
    private float timer = 0;

    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnPipe();
            timer = 0;
        }
    }

    void SpawnPipe()
    {
        float y = Random.Range(-2f, 2f);
        Instantiate(pipePrefab, new Vector3(10, y, 0), Quaternion.identity);
    }
}