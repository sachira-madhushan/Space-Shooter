using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInstantiate : MonoBehaviour
{
    public GameObject[] enemyLocations;
    public GameObject Enemy;
    int startTime = 0;
    void Start()
    {
        
    }

    
    void FixedUpdate()
    {
        startTime += 1;

        if (startTime > 100)
        {
            int randomNumber = Random.Range(0, 4);
            Instantiate(Enemy, enemyLocations[randomNumber].transform.position, Quaternion.identity);
            startTime = 0;
        }
    }
}
