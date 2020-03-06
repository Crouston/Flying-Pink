using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovement : MonoBehaviour
{
    public int speed;
    public int jumpForce;
    private Rigidbody2D rb;
    private bool play,dead;
    public GameManager gameManager;
    public ScoreHandler scoreHandler;
    public AudioSource jumpSound;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        play = false;
        rb.bodyType = RigidbodyType2D.Static;
        jumpSound = GetComponent<AudioSource>();
        dead = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (play)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began  && !play)
            {
                play = true;
                rb.bodyType = RigidbodyType2D.Dynamic;
                jumpSound.Play();
            }
            if (touch.phase == TouchPhase.Began && !dead)
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpForce);
                jumpSound.Play();
            }
        }
        if (Input.GetKeyDown(KeyCode.Space)  && !play)
        {
            play = true;
            rb.bodyType = RigidbodyType2D.Dynamic;
            jumpSound.Play();
        }
        if (Input.GetKeyDown(KeyCode.Space)  && !dead)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            jumpSound.Play();
        }
    }

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("ScoreCollider"))
        {
            scoreHandler.AddScore();
        }
        if (collision.gameObject.CompareTag("Pipe"))
        {
            dead = true;
            gameManager.Lose();
            speed = 0;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("BottomCollider"))
        {
            dead = true;
            gameManager.Lose();
            Time.timeScale = 0f;
        }
    }
}
