using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text ScoreText;

    private int _score;

    private void Start()
    {
        _score = 0;
    }

    public void AddScore()
    {
        _score++;
    }

    public void UpdateScore()
    {
        ScoreText.text = "Score : " + _score.ToString();
    }
}
