using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleMoveFour : MonoBehaviour
{
    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        if (Input.GetKey("up"))
        {
            rb.velocity = new Vector2(0, 10);
        }
        else if (Input.GetKey("down"))
        {
            rb.velocity = new Vector2(0, -10);
        }
        else if (Input.GetKey("left"))
        {
            rb.velocity = new Vector2(-10, 0);
        }
        else if (Input.GetKey("right"))
        {
            rb.velocity = new Vector2(10, 0);
        }
        else
        {
            rb.velocity = Vector2.zero;
        }
    }
}
