using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float yForce;
    public float xForce;
    public float xDirection;
    public float yDirection;
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
        if (transform.position.y >= 4)
        {
            Debug.Log("edsafcesd");
            yDirection = -1;
            enemyRigidbody.AddForce(Vector2.up * yForce * yDirection);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {     
        Vector2 jumpForce = new Vector2(xForce * xDirection, yForce * yDirection);
        enemyRigidbody.AddForce(jumpForce);
        if(collision.gameObject.tag == "Ground")
        {
            yDirection = -1;
        }
    }
}
