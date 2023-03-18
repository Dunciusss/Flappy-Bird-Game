using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public Rigidbody2D rb;
    public AudioSource jumpSound;
    public AudioSource collisionSound;


    private void Update()
    {
        if (Input.anyKey) Jump();
        
    }
    void Jump()
    {
        jumpSound.Play();
        rb.velocity = new Vector2(0, 5);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Ground")
        {
            collisionSound.Play();
        }
    }
}
