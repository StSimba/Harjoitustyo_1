using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    //Luodaan muuttujat
    public float score = 0;
    public TextMeshProUGUI scoreText;
    public float scoreRate = 10f;
    private bool GameOver = false;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!GameOver)
        {
            //Lis‰t‰‰n pisteit‰ ja siirret‰‰n tieto ui:n score tekstiin
            score += scoreRate * Time.deltaTime;
            UpdateScoreText();
        }
    }

    //asetetaan tilaksi Game Over
    public void gameOver()
    {
        GameOver = true;
    }

    private void UpdateScoreText()
    {
        //Tulostetaan score ja pyˆristet‰‰n se tasalukuihin
        scoreText.text = "Score: " + Mathf.FloorToInt(score).ToString();

    }

    public void ResetScore()
    {
        //Resetoidaan pisteet ja pelaajan tila
        score = 0;
        GameOver = false;
        UpdateScoreText();
    }
}
