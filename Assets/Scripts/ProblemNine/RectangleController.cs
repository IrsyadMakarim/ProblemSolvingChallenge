using UnityEngine;

public class RectangleController : MonoBehaviour
{
    private GameObject Player;
    private ScoreManager _score;
    private bool _playerInRange = false;
    private RectangleManager _rectManager;
    private bool _rectangleDestroyed;

    private void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        _score = FindObjectOfType<ScoreManager>();
        _rectManager = FindObjectOfType<RectangleManager>();
    }

    private void Update()
    {
        if (_playerInRange && !_rectangleDestroyed)
        {
            DestroyObject();
            Debug.Log(_rectangleDestroyed);

            Invoke("ActivateObject", 3);
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

    public void ActivateObject()
    {
        _playerInRange = false;
        _rectangleDestroyed = false;
        gameObject.transform.position = _rectManager.RandomizePosition();
        gameObject.SetActive(true);
    }

    public void DestroyObject()
    {
        gameObject.SetActive(false);
        _score.AddScore();
        _score.UpdateScore();
        _rectangleDestroyed = true;
    }
}
