using UnityEngine;

public class CircleMove : MonoBehaviour
{
    Rigidbody2D rb;

    private int xPos;
    private int yPos;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        xPos = Random.Range(-10, 10);
        yPos = Random.Range(-10, 10);

        Move();
    }

    private void Move()
    {
        rb.velocity = new Vector2(xPos, yPos);
    }
}
