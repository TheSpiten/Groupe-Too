using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave2Spawner : MonoBehaviour
{
    public GameObject Enemy;
    public Transform spawnPoint;
    public float spawndelay = 2.0f;
    public float timeactual = 5.0f;
    private float stagetime = 20f;
    public int cap = 5;
    private GameObject[] getCount;
    private int count = 0;
    public static bool Spawning = false;


    void Start()
    {
        timeactual = spawndelay;
        cap -= 1;
        

    }

    void Update()
    {
        getCount = GameObject.FindGameObjectsWithTag("Enemy1");
        count = getCount.Length;
        stagetime -= Time.deltaTime;
        if (stagetime <= 0)
        {
            spawndelay = spawndelay - 0.5f;
            stagetime = 20f;


        }
        if (count <= cap)
        {
            timeactual -= Time.deltaTime;

            if (timeactual <= 0.0f && Spawning == true)
            {
                SpawnEnemy();

                timeactual = spawndelay;
            }

        }

       

    }
    void SpawnEnemy()
    {
        Instantiate(Enemy, spawnPoint.position, spawnPoint.rotation);
    }
}
