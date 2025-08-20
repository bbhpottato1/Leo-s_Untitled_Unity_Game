using UnityEngine;

public class Player_Movement : MonoBehaviour
{

    public float speed;
    public float drag;
    public Rigidbody2D body;
    public BoxCollider2D groundCheck;
    public LayerMask groundMask;
    public bool grounded;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");

        if (Mathf.Abs(xInput) > 0)
        {
            body.linearVelocity = new Vector2(xInput * speed, body.linearVelocity.y);
        }
        if (Mathf.Abs(yInput) > 0)
        {
            body.linearVelocity = new Vector2(body.linearVelocity.x, yInput * speed);
        }

        //Vector2 direction = new Vector2(xInput, yInput).normalized;

        //body.linearVelocity = direction * speed;
    }
    void FixedUpdate()
    {
        Checkground();
        if (grounded)
        {
            body.linearVelocity *= drag;
        }

    }

    void Checkground()
    {
        
    }
}
