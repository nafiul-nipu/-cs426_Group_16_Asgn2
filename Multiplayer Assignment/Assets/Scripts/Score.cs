using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    int maxScore = 5;

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

        if (score < maxScore){
            print(score);
            scoreText.text = "Score: " + score;
        }else if (score == maxScore){
            SceneManager.LoadScene("Win Scene");
            scoreText.text = "Game!";
        }
            
    }

    public void DeductPoint()
    {
        score--;
        scoreText.text = "Score: " + score;
    }
}
