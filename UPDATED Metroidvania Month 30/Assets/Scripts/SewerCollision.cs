using UnityEngine;

public class SewerCollision : MonoBehaviour
{
    public GameObject NicoleBubble1;
    public GameObject NicoleBubble2;
    public GameObject NicoleBubble3;
    //public bool CanTalk;

    //Is the player colliding with other characters?
    public bool Nicole1Talk = false;
    public bool Nicole2Talk = false;
    public bool Nicole3Talk = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //CanTalk = false;
        NicoleBubble1.SetActive(false);
        NicoleBubble2.SetActive(false);
        NicoleBubble3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("Trigger");
        if (collision.gameObject.name == "Nicole 1")
        {
            Debug.Log("Player Collision");
            NicoleBubble1.SetActive(true);
            Nicole1Talk = true;
        }

        if (collision.gameObject.name == "Nicole 2")
        {
            Debug.Log("Player Collision");
            NicoleBubble2.SetActive(true);
            Nicole2Talk = true;
        }

        if (collision.gameObject.name == "Nicole 3")
        {
            Debug.Log("Player Collision");
            NicoleBubble3.SetActive(true);
            Nicole3Talk = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //Debug.Log("Trigger");
        if (collision.gameObject.name == "Nicole 1")
        {
            Debug.Log("Player Leaving");
            NicoleBubble1.SetActive(false);
            Nicole1Talk = false;
        }

        if (collision.gameObject.name == "Nicole 2")
        {
            Debug.Log("Player Collision");
            NicoleBubble2.SetActive(false);
            Nicole2Talk = true;
        }

        if (collision.gameObject.name == "Nicole 3")
        {
            Debug.Log("Player Collision");
            NicoleBubble3.SetActive(true);
            Nicole3Talk = true;
        }
    }


}
