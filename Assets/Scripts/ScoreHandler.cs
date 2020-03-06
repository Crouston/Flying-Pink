using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreHandler : MonoBehaviour
{
    public TextMeshProUGUI scoreText,highscoreText,scoreTextAfter;
    private int score;
    private int highscore;
    public AudioSource scoreSound;
    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreText = GetComponent<TextMeshProUGUI>();
        scoreSound = GetComponent<AudioSource>();
        gameManager.GetComponent<GameManager>().scoreHandler = this;
        highscore = PlayerPrefs.GetInt("Highscore");
        highscoreText.text = "" + highscore;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "" + score;
        scoreTextAfter.text = scoreText.text;
        gameManager.score = score;
    }

    public void AddScore()
    {
        score++;
        scoreSound.Play();
    }
}
