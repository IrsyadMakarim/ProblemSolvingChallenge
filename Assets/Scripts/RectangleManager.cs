using UnityEngine;

public class RectangleManager : MonoBehaviour
{
    public GameObject[] Rectangles;
    public GetSquareArea _area;

    private float randX;
    private float randY;
    private bool _readyToSpawn;

    private void Awake()
    {
        RandomizePosition();

        for (int i = 0; i < Rectangles.Length; i++)
        {
            Instantiate(Rectangles[i], new Vector3(randX, randY, 0), Quaternion.identity);
            RandomizePosition();
        }
    }

    public Vector3 RandomizePosition()
    {
        randX = Random.Range(_area.left, _area.right);
        randY = Random.Range(_area.down, _area.up);
        return new Vector3(randX, randY, 0);
       
    }
}
