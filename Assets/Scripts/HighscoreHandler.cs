using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighscoreHandler : MonoBehaviour
{
    public TextMeshProUGUI highscore;

    // Start is called before the first frame update
    void Start()
    {
        highscore.text = PlayerPrefs.GetInt("Highscore", 0).ToString();
    }
    
}
