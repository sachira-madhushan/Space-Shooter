using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody2D rb;
    private Score scoreScript;
    private AudioSource audioSource;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        scoreScript = GameObject.Find("Score").GetComponent<Score>();
        audioSource = GameObject.Find("EnemyExplosion").GetComponent<AudioSource>();
    }

    
    void FixedUpdate()
    {
        
        rb.velocity = new Vector2(0, -1);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Missile")
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
            scoreScript.IncreaseScore();
            audioSource.Play();
        }
    }

    
}
