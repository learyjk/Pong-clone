using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        float randomNumber = Random.Range(0f, 1.0f);

        if (randomNumber < 0.5) {
            rb.AddForce(new Vector2(80,10));
        }
        else {
            rb.AddForce(new Vector2(-80,-10));
        }
    }

    void OnCollisionEnter2D(Collision2D colInfo) {
        if (colInfo.collider.tag == "Player") {
            // Ball speed increases a bit with each hit and is dependent upon 1/3 of paddle speed.
            rb.velocity = new Vector2(rb.velocity.x * 1.02f, rb.velocity.y/2 + colInfo.rigidbody.velocity.y/3);
        }
    }
}
