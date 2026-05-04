using UnityEngine;

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
            Debug.Log("Jump triggered");
            rb.velocity = Vector2.up * jumpForce; 
        }
    }
}