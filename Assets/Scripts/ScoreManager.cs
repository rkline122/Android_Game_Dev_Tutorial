using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public float pointsPerSecond;
    public Text scoreText;
    public Text highScoreText;
    private float score;
    private float highScore;
    public bool isScoreIncreasing;

    public void resetScore(){
        score = 0;
    }

    // Start is called before the first frame update
    void Start()
    {
        isScoreIncreasing = true;

        if(PlayerPrefs.HasKey("HighScore")){
            highScore = PlayerPrefs.GetFloat("HighScore");
        }

    }


    // Update is called once per frame
    void Update()
    {
        if(isScoreIncreasing){
            score += pointsPerSecond*Time.deltaTime;
        }

        if(score > highScore){
            highScore = score;
            PlayerPrefs.SetFloat("HighScore", highScore);
        }

        scoreText.text = Mathf.Round(score).ToString();
        highScoreText.text = Mathf.Round(highScore).ToString();


    }
}
