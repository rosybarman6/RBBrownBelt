using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float yForce;
    private Rigidbody2D enemyRigidbody;
    public float speed;

    void Start()
    {
        enemyRigidbody = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        if(transform.position.x <= -8)
        {
            
        }
        if (transform.position.x >= 8)
        {
            
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collison.gameObject.tag == "Ground")
        {

        }
    }
}
