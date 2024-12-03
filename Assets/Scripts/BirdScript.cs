using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public float jumpForce;
    public Rigidbody2D rb;
    public LogicScript logic;
    public bool alive = true;
    public AudioSource wingFlip;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && alive)
        {
            rb.velocity = Vector2.up * jumpForce;
            wingFlip.Play();
        }

        if(transform.position.y < -17.6 ||  transform.position.y > 17.6)
        {
            logic.gameOver();
            alive = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "pipe" || collision.gameObject.tag == "pipeDown")
        {
            logic.gameOver();
            alive = false;
        }
    }
}
