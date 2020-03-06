using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject loseText,retryButton,scoreBoard;
    public AudioSource birdDeadSound;
    private bool deadSoundPlayed;
    public int score;
    public ScoreHandler scoreHandler;
    // Start is called before the first frame update
    void Start()
    {
        birdDeadSound = GetComponent<AudioSource>();
        Time.timeScale = 1f;
        deadSoundPlayed = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Lose()
    {
        if (!deadSoundPlayed)
        {
            birdDeadSound.Play();
            deadSoundPlayed = true;
        }
        if(PlayerPrefs.GetInt("Highscore",0) < score)
        {
            PlayerPrefs.SetInt("Highscore",score) ;
        }
        scoreHandler.scoreText.gameObject.SetActive(false);
        scoreBoard.SetActive(true);
        loseText.SetActive(true);
        retryButton.SetActive(true);
    }
}
