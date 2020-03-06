using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreHandler : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int score;
    public AudioSource scoreSound;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreText = GetComponent<TextMeshProUGUI>();
        scoreSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "" + score;
    }

    public void AddScore()
    {
        score++;
        scoreSound.Play();
    }
}
