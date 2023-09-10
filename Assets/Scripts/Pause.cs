using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{

    public GameObject pauseWindow;


    private void Start()
    {
        pauseWindow.SetActive(false);
    }
    public void PauseButton()
    {
        Time.timeScale = 0;
        pauseWindow.SetActive(true);
    }

    public void Resume()
    {
        Time.timeScale = 1;
        pauseWindow.SetActive(false);
    }

    public void Exit()
    {
        SceneManager.LoadScene("Home");
    }
}
