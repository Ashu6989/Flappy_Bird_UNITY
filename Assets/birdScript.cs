using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdScript : MonoBehaviour
{
    public float jumpForce = 5f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
{
    if (Input.GetKeyDown(KeyCode.Space))
    {
        rb.velocity = Vector2.up * jumpForce;
    }

    if (Input.GetKeyDown(KeyCode.R))
    {
        Time.timeScale = 1;
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Game Over");
        Time.timeScale = 0;
    }

}