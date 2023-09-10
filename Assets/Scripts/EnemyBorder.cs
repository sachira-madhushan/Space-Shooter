using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBorder : MonoBehaviour
{
    public HealthBar healthBar;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            healthBar.Damage();
            Destroy(collision.gameObject);
        }
    }
}
