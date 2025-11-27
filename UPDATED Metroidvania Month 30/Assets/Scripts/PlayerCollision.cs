using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public GameObject SpeechBubble;
    public bool CanTalk;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpeechBubble.SetActive(false);
        CanTalk = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("Trigger");
        if (collision.gameObject.name == "Supervisor")
        {
            Debug.Log("Player Collision");
            SpeechBubble.SetActive(true);
            CanTalk = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //Debug.Log("Trigger");
        if (collision.gameObject.name == "Supervisor")
        {
            Debug.Log("Player Leaving");
            SpeechBubble.SetActive(false);
            CanTalk = false;
        }
    }

}
