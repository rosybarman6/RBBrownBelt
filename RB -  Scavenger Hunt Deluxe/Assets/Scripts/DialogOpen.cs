using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogOpen : MonoBehaviour
{

    public string dialog;
    public GameObject interfaceManager;
    public PlayerHolding pHolding;
    public bool begin = true;
    public bool end = false;
    private string[] collectibles;
    private int clue;
    //private int clue1;

    private AudioSource greeting;

    // Start is called before the first frame update
    void Start()
    {
        greeting = GetComponent<AudioSource>();
        collectibles = new string[] { "film", "balloons", "life saver", "bull's eye", "pipe", "key", "fish", "birdhouse", "red airhorn", "magic hat" };
        createClue();
        begin = true;
    }

    public void createClue()
    {
        clue = Random.Range(0, 9);
        
        searchDialog();
    }
    public void searchDialog()
    {
        if(clue == (0)) 
        {
            dialog = "Today's movie night I need my " + collectibles[clue] + "!";
        } else if (clue == (1)) 
        {
            dialog = "Today's my birthday, can you help me find my " + collectibles[clue] + "?";
        } else if (clue == (2)) 
        {
            dialog = "I'm going to the beach, can you help me find my " + collectibles[clue] + "?";
        } else if (clue == (3)) 
        {
            dialog = "I need to practice my archery and i need my " + collectibles[clue] + "!";
        } else if (clue == (4)) 
        {
            dialog = "I'm manifesting my inner Old man, I need a " + collectibles[clue] + ".";
        } else if (clue == (5)) 
        {
            dialog = "I'm locked out of my house! I need a " + collectibles[clue] + "!";
        } else if (clue == (6))
        {
            dialog = "Have you seen Gerald? my pet " + collectibles[clue] + "?";
        } else if (clue == (7)) 
        {
            dialog = "theres so many birds near my backyard, they need a " + collectibles[clue] + ".";
        } else if (clue == (8)) 
        {
            dialog = "I'm trying to prank my friend! I need my " + collectibles[clue] + "!";
        } else if (clue == (9)) {
            dialog = "I can't find my bunny! maybe hes in a " + collectibles[clue] + "! help me find one!";
        }


    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!begin && pHolding.Verify())
        {
            checkClue();
        }
        Debug.Log("hit");
        greeting.Play(0);
        interfaceManager.GetComponent<InterfaceManager>().ShowBox(dialog, clue);
    }

    private void checkClue()
    {
        if (pHolding.holdValue == clue)
        {
            dialog = "You found my " + collectibles[clue] + "! Hooray!";
            end = true;
        }
        else
        {
            dialog = "No, that's not my " + collectibles[clue] + ".";
        }
    }

    public void coinsScattered()
    {
        begin = false;
    }

}
