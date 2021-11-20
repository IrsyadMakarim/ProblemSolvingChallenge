using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RectangleController : MonoBehaviour
{
    private GameObject Player;
    private ScoreManager _score;
    private bool _playerInRange = false;

    private void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        _score = FindObjectOfType<ScoreManager>();
    }

    private void Update()
    {
        if (_playerInRange)
        {
            DestroyObject();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == Player && collision.isTrigger == false)
        {
            _playerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject == Player)
        {
            _playerInRange = false;
        }
    }

    public void DestroyObject()
    {
        Destroy(gameObject);
        _score.AddScore();
        _score.UpdateScore();
    }
}
