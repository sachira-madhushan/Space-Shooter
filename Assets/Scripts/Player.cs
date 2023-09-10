using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public FixedJoystick fixedJoystick;
    private float speed = 5;
    private Rigidbody2D rb;
    public GameObject missile;
    public Transform fireloaction;
    public HealthBar healthBar;
    public AudioSource audioSource;
    public AudioClip shootSound,enemyExplosion;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    
    void FixedUpdate()
    {

        float value=fixedJoystick.Horizontal;
        rb.velocity=new Vector2(value* speed, 0);


    }

    public void Fire()
    {
        Instantiate(missile, fireloaction.position, Quaternion.identity);
        audioSource.clip = shootSound;
        audioSource.Play();
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            audioSource.clip = enemyExplosion;
            audioSource.Play();
            healthBar.Damage();
            Destroy(collision.gameObject);

        }
    }
}
