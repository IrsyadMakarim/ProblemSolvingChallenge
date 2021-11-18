using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleManager : MonoBehaviour
{
    public GameObject Circle;

    private void Awake()
    {
        Instantiate(Circle, new Vector3(0, 0, 0), Quaternion.identity);
    }
}
