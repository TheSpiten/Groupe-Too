using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner1 : MonoBehaviour
{
    public GameObject[] enemies;
    public Transform spawnpoint;
    public float spawnWait;
    
    public int startW;
    public bool stop;

    int randomEnemy;
    int enemySpawned;
    void Start()
    {
        StartCoroutine(waitSpawn()); 
    }

   
    void Update()
    {
        spawnWait = 2f;
    }

    IEnumerator waitSpawn ()
    {
        yield return new WaitForSeconds(startW);

        while (!stop)
        {
            randomEnemy = Random.Range(0, 2);
            Instantiate(enemies[randomEnemy], spawnpoint.position, gameObject.transform.rotation);
            enemySpawned++;

            if (enemySpawned == 10)
            {
                stop = true;
            }
            yield return new WaitForSeconds(spawnWait);
        }
    }
}
