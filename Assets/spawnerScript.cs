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
    float gapSize = 3.8f;   // space between pipes
    float centerY = Random.Range(-1.5f, 1.5f);

    // Bottom pipe
    Instantiate(pipePrefab, new Vector3(10, centerY - gapSize, 0), Quaternion.identity);

    // Top pipe (flipped)
    GameObject topPipe = Instantiate(pipePrefab, new Vector3(10, centerY + gapSize, 0), Quaternion.identity);
    topPipe.transform.rotation = Quaternion.Euler(0, 0, 180);
}
}