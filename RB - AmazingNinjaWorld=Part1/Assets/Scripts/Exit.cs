using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    public GameObject HealPlayer;
    private int lives = 3;
    SpriteRenderer m_renderer;
    public GameObject gem;
    public GameObject background;
    public string teleportDestination;
    private GameObject[] hearts;

    private void Start()
    {
        m_renderer = gem.GetComponent<SpriteRenderer>();
       
    }

    

    void OnTriggerEnter(Collider other)
    {
        if(m_renderer.enabled == false)
        {
            background.GetComponent<GameManager>().TeleportOpen(teleportDestination);
            HealPlayer();
        }
        
    }

    
}
