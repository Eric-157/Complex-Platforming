using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rbmovement : MonoBehaviour{
    public int xSpeed = 10;
    public int ySpeed = 0;
    public float jumpAmount = 2;
    public Rigidbody2D rb;
    public Vector2 movement;
    public bool dJump, wJump, bJump;
    public static int maxJump;
    // Start is called before the first frame update
    void Start()
    {
        maxJump = 0;
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update() {
        movement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        rb.velocity = new Vector2(0, rb.velocity.y);
        
        if (Input.GetKeyDown(KeyCode.Space)) {
            if (rb.velocity.y >= -0.004 && rb.velocity.y <= 0.004) {
                rb.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);
            }  
        }
        else {
        }
    }
    void FixedUpdate() {
        moveDave(movement);
    }

    void moveDave(Vector2 movement) {
        rb.AddForce(movement * xSpeed);
    }
}
