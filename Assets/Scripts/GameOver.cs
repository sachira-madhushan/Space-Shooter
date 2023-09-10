using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class GameOver : MonoBehaviour
{
    public TextMeshProUGUI score;



    private void Update()
    {
        score.text = "Score :" + PlayerPrefs.GetInt("Score").ToString();
    }
    public void Replay()
    {
        SceneManager.LoadScene("Game");
        if(PlayerPrefs.GetInt("HighScore",0)< PlayerPrefs.GetInt("Score"))
        {
            PlayerPrefs.SetInt("HighScore", PlayerPrefs.GetInt("Score"));
        }
    }

    public void Exit()
    {
        SceneManager.LoadScene("Home");
        if (PlayerPrefs.GetInt("HighScore", 0) < PlayerPrefs.GetInt("Score"))
        {
            PlayerPrefs.SetInt("HighScore", PlayerPrefs.GetInt("Score"));
        }
    }
}
