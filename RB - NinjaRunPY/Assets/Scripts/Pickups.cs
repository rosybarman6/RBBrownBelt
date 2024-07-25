using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pickups : MonoBehaviour
{
    public int score;
    public Text scoreText;
    public GameObject Pickup;
    public GameObject door; 

    void Start()
    {
        //Pickup.Stop();
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject);
        if (other.gameObject.CompareTag("coin"))
        {
            /*
            score++;
            scoreText.text = score.ToString();
            */
            Destroy(other.gameObject);
            //Pickup.Play();
            Destroy(door);
        }
    }
}
