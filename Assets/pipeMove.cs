using UnityEngine;

public class PipeMove : MonoBehaviour
{
    public static float globalSpeed = 2f;

    void Update()
    {
        transform.position += Vector3.left * globalSpeed * Time.deltaTime;
    
        globalSpeed += Time.deltaTime * 0.02f;
    }
}