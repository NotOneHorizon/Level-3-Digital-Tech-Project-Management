using System.Collections.Specialized;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    public float jumpHeight;
    public bool isGrounded = false;
    GameObject Player;
    public float gravity;
    public Rigidbody2D rb2D;
    private void Start()
    {
        Player = gameObject.transform.gameObject;
    }
    // Collision used to check if the player is touching the ground 
    void OnCollisionEnter2D(Collision2D Collision)
    {
        if (Collision.collider.tag == "Ground")
        {
            Player.GetComponent<PlayerMovement>().isGrounded = true;
        }
    }

    void OnCollisionExit2D(Collision2D Collision)
    {
        if (Collision.collider.tag == "Ground")
        {
            Player.GetComponent<PlayerMovement>().isGrounded = false;
        }

    }

    private void FixedUpdate()
    {
        if (rb2D.position.y < -1f)
        {
            FindObjectOfType<GameConductor>().EndGame();
        }
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, gravity);
        }

        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, gravity);
        }
        Jump();
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += (movement * Time.deltaTime * moveSpeed);
    }

    void Jump()
    {
        if (Input.GetKey(KeyCode.Space) && isGrounded == true)
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, jumpHeight);
    }
}
