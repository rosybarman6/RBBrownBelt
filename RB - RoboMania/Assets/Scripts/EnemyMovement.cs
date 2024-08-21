using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float yForce;
    public float xForce;
    public float xDirection;
    private Rigidbody2D enemyRigidbody;
    

    void Start()
    {
        enemyRigidbody = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        if(transform.position.x <= -8)
        {
            xDirection = 1;
            enemyRigidbody.AddForce(Vector2.right * xForce);
        }
        if (transform.position.x >= 8)
        {
            xDirection = -1;
            enemyRigidbody.AddForce(Vector2.left * xForce);
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            Vector2 jumpForce = new Vector2(xForce * xDirection, yForce);
            enemyRigidbody.AddForce(jumpForce);
        }
    }
}
