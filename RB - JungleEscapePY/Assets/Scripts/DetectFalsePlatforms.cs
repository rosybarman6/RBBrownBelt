using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectFalsePlatforms : MonoBehaviour
{
    public Transform Player;
    
    void Update()
    {
       bool hit = Physics.Raycast(transform.position, transform.forward, 3f, 1 << 8);

        if (hit)
        {
            Debug.Log("CAUTIOUN, PRECAUCIÓN");
        }
        else
        {
            Debug.Log("ALL CLEAR, TODO CLARO");
        }
    }
}