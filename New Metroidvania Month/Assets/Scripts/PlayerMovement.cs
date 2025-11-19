using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float move;
    public float JumpVelocity = 3;
    public float speed = 5;
    public float gravity = 1;
    public float fallMultiplier = 5;

    //Is the player on the ground?
    public bool grounded => groundCollisions >= 1;
        public int groundCollisions;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        move = Input.GetAxisRaw("Horizontal");

        rb.linearVelocity = new Vector2(speed * move, rb.linearVelocity.y);

        if(Input.GetKeyDown(KeyCode.Space) && groundCollisions >= 1)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, 0);
            rb.AddForce(Vector2.up * JumpVelocity, ForceMode2D.Impulse);
        }

        //Check to see if the player is falling down
        if (rb.linearVelocity.x < 0)
        {
            rb.gravityScale = gravity * fallMultiplier;
        }
            
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Floor"))
        {
            
            groundCollisions++;
        }

        
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Floor"))
        {
            groundCollisions--;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        /*
        if (collision.gameObject.name == "Intro Exit")
        {
            SceneManager.LoadScene(sceneName: "BaseCamp");
        }
        */
    }
}
