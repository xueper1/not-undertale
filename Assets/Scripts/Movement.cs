using UnityEngine;

public class PlayerMovement2D : MonoBehaviour
{
    public float moveSpeed = 5f; 
    private Rigidbody2D rb;
    private Vector2 moveInput;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        moveInput.x = Input.GetAxis("Horizontal");
        rb.velocity = moveInput * moveSpeed;
    }

    void FixedUpdate()
    {

        
    }
}
