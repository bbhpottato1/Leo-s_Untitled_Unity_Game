using UnityEngine;

public class Player_Movement : MonoBehaviour{

    public float speed;
    public Rigidbody2D body;
    void Start(){
        
    }

    // Update is called once per frame
    void Update()
    {

        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");

        if (Mathf.Abs(xInput) > 0){
            
        }
        if (Mathf.Abs(yInput) > 0){
            
        }

        Vector2 direction = new Vector2(xInput, yInput).normalized;

        body.linearVelocity = direction * speed;
    }
}
