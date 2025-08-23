using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;

    private float xInput;
    [SerializeField] private float moveSpeed = 4f;
    [SerializeField] private float jumpForce = 8f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Jump()
    {
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
    }

    private void HandleMovement()
    {
        rb.linearVelocity = new Vector2(xInput * moveSpeed, rb.linearVelocity.y);
        
    }

    private void HandleInput()
    {
        xInput = Input.GetAxisRaw("Horizontal");
        HandleMovement();

        if (Input.GetKeyDown(KeyCode.Space))
            Jump();
    }


    private void Update()
    {
        HandleInput();
        HandleMovement();
    }

    
}
