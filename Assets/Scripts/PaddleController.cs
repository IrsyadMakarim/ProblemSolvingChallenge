using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
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
        if (Input.GetKey("left"))
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
