using UnityEngine;
using TMPro;

public class Collection : MonoBehaviour
{
    public int Coins = 0;
    public TextMeshProUGUI CollectableText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CollectableText.text = ("Coins: " + Coins);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("Trigger");
        if(collision.gameObject.CompareTag("Collectable"))
        {
            Destroy(collision.gameObject);
            Coins++;
            Debug.Log(Coins);
        }
    }
}
