using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed;

    private void FixedUpdate()
    {
        if(transform.position.x <= -8)
        {
            speed = speed * -1;
        }
        if (transform.position.x >= 8)
        {
            speed = speed * -1;
        }
        float newXPosition = transform.position.x + speed * Time.deltaTime;
        float newYPosition = transform.position.y;
        Vector2 newposition = new Vector2(newXPosition, newYPosition);
        transform.position = newposition;
    }
}
