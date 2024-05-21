using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float xSpeed = 0.0f;
        float horizotalKey = Input.GetAxis("Horizontal");

        if (horizotalKey > 0)   // →キー 
        {
            Debug.Log(" > 0");
            xSpeed = speed;
        }
        else if (horizotalKey < 0)   // ←キー
        {
            xSpeed = -speed;
        }
        else
        {
            xSpeed = 0.0f;
        }

        rb.velocity = new Vector2(xSpeed, rb.velocity.y);
    }
}
