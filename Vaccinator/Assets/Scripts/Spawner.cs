using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawner : MonoBehaviour
{


    public GameObject Enemy;
    public Transform spawnPoint;
    public float spawndelay = 2.0f;
    public float timeactual = 5.0f;
    public float stagetime = 5f;
    public int cap = 5;
    private GameObject[] getCount;
    private int count = 0;


    void Start()
    {
        timeactual = spawndelay;
        cap -= 1;

    }

    void Update()
    {
        getCount = GameObject.FindGameObjectsWithTag("Enemy");
        count = getCount.Length;
        stagetime -= Time.deltaTime;
        if (stagetime <= 0)
        {
            Wave2Spawner.Spawning = true;

        }
        if (count <= cap)
        {
            timeactual -= Time.deltaTime;

            if (timeactual <= 0.0f)
            {
                SpawnEnemy();

                timeactual = spawndelay;
            }

        }

        //if ( stagetime == 0 && GameObject.FindGameObjectWithTag("Enemy") == null)
        //{
            
        //}

    }
    void SpawnEnemy()
    {
        Instantiate(Enemy, spawnPoint.position, spawnPoint.rotation);
    }

}


