using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthBar : MonoBehaviour
{
    private Image healthBar;
    private float health = 100;
    public GameObject Player;
    public GameObject gameOverWindow;

    private AudioSource audioSource;
    public AdManager adManager;
    private bool Adplayed = false;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        Time.timeScale = 1;
        healthBar = GetComponent<Image>();
        gameOverWindow.SetActive(false);
        Adplayed = false;
    }
    private void Update()
    {
        if (health <= 0)
        {
            audioSource.Play();
            Time.timeScale = 0;
            Destroy(Player);
            gameOverWindow.SetActive(true);

            int value = Random.Range(0, 2);
            if (value == 1 & !Adplayed)
            {
                adManager.ShowNonRewardedAd();
                Adplayed = true;
            }
            
        }
    }
    public void Damage()
    {
        health -= 20;
        healthBar.fillAmount = health / 100;
    }
}
