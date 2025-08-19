using UnityEngine;

public class Player_Movement : MonoBehaviour{

    public Rigidbody2D body;
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){

        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");
        
        body.linearVelocity = new Vector2(xInput, yInput);
    }
}
