using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Score : MonoBehaviour
{
    public TextMeshProUGUI score;

    private int scoreValue = 0;

    private void Start()
    {
        PlayerPrefs.SetInt("Score", 0);
    }
    public void IncreaseScore()
    {
        scoreValue += 1;
        score.text = "SCORE :" + scoreValue;
        PlayerPrefs.SetInt("Score", scoreValue);
    }
}
