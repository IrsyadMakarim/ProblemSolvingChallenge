using UnityEngine;

public class CircleMove : MonoBehaviour
{
    Rigidbody2D rb;

    private int xPos;
    private int yPos;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        yPos = Random.Range(-10, 0);

        Invoke("Move", 2);
    }

    private void Move()
    {
        rb.velocity = new Vector2(0, yPos);
    }
}
