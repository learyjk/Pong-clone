using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public Rigidbody2D rb;
    public KeyCode moveUp;
    public KeyCode moveDown;
    public float speed = 10;

    void Update()
    {
        if (Input.GetKey(moveUp)) {
            rb.velocity = new Vector2(0.0f, speed);
        }
        else if (Input.GetKey(moveDown)) {
            rb.velocity = new Vector2(0.0f, -speed);
        }
        else {
            rb.velocity = new Vector2(0.0f, 0.0f);
        }
    }
}
