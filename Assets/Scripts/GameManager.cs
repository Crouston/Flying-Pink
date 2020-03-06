using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject loseText,retryButton;
    public AudioSource birdDeadSound;
    private bool deadSoundPlayed;
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
        loseText.SetActive(true);
        retryButton.SetActive(true);
    }
}
