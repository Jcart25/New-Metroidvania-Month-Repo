using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 5f;
    public float JumpVelocity = 3;
    private Vector2 movement;

    //Is the player on the ground?
    public bool grounded => groundCollisions >= 1;
    public int groundCollisions;

    //Other Script References
    public PlayerCollision PC;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float input = Input.GetAxisRaw("Horizontal");
        movement.x = input * speed * Time.deltaTime;
        transform.Translate(movement);
        Jump();
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && groundCollisions >= 1 && PC.CanTalk == false)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, 0);
            rb.AddForce(Vector2.up * JumpVelocity, ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {

            groundCollisions++;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            groundCollisions--;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Sewer Entrance")
        {
            SceneManager.LoadScene(sceneName: "Sewers");
        }
    }
}
