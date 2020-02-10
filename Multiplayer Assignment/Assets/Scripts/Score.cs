using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public int maxScore = 9;

    int score;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreText.text = "Score: " + score;
    }
    
    public void AddPoint()
    {
        score++;

        if (score != maxScore)
            scoreText.text = "Score: " + score;
        else
            scoreText.text = "Game!";
    }
}
