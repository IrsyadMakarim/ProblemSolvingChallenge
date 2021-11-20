using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleMoveFive : MonoBehaviour
{
    Rigidbody2D rb;

    float MoveSpeed = 100f;

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
        if (Input.GetMouseButton(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 dir = (mousePos - transform.position).normalized;
            rb.velocity = new Vector2(dir.x * MoveSpeed, dir.y * MoveSpeed);
        }
        else
        {
            rb.velocity = Vector2.zero;
        }
    }
}
