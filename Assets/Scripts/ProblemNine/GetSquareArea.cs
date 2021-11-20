using UnityEngine;

[DefaultExecutionOrder(-1)]
public class GetSquareArea : MonoBehaviour
{
    public float left;
    public float right;
    public float up;
    public float down;

    private void Awake()
    {
        GetAroundLength();
    }

    void GetAroundLength()
    {
        left = -GetLength(Vector2.left) + 1;
        right = GetLength(Vector2.right) - 1;
        up = GetLength(Vector2.up) - 1;
        down = -GetLength(Vector2.down) + 3;
    }

    float GetLength(Vector2 direction)
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, direction);
        if (hit.collider != null)
        {
            return (hit.point - (Vector2)transform.position).magnitude;
        }
        return -1;
    }
}
