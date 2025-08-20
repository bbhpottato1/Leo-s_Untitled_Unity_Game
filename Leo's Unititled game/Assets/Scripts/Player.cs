using UnityEditor.Callbacks;
using UnityEngine;

public class Player : MonoBehaviour
{
    public string playerName = "Astronaut";
    public int age = 31;
    public float moveSpeed = 2.5f;
    public bool gameOver = true;

    public Rigidbody2D rb;

    private void Awake()
    {

    }
}
