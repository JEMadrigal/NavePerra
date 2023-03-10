using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class ScoreController : MonoBehaviour
{
    public static ScoreController instance;

    public TextMeshProUGUI  scoreText;

    int score = 0;

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score: " + score.ToString();
    }

    public void AddPoint()
    {
        score += 100;
        scoreText.text = "Score: " + score.ToString();
    }
}
