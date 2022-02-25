using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefabs;
    private float rangeX = 5.5f;
    private float rangeZ = 4.47f;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    private GameOver gameEnd;
    // Start is called before the first frame update
    void Start()
    {
        gameEnd = GameObject.Find("Player").GetComponent<GameOver>();

        InvokeRepeating("SpawnRandomEnemy", startDelay, spawnInterval);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void SpawnRandomEnemy()
    {
        if (gameEnd.gameOver == false)
        {
            Vector3 spawnPosition1 = new Vector3(Random.Range(rangeX, rangeX + 3), 0, rangeZ);
            Instantiate(enemyPrefabs, spawnPosition1, enemyPrefabs.transform.rotation);

            Vector3 spawnPosition2 = new Vector3(Random.Range(rangeX, rangeX + 3), 0.1f, -rangeZ);
            Instantiate(enemyPrefabs, spawnPosition2, enemyPrefabs.transform.rotation);

            Vector3 spawnPosition3 = new Vector3(Random.Range(-rangeX - 3, -rangeX), 0.1f, -rangeZ);
            Instantiate(enemyPrefabs, spawnPosition3, enemyPrefabs.transform.rotation);

            Vector3 spawnPosition4 = new Vector3(Random.Range(-rangeX - 3, -rangeX), 0, rangeZ);
            Instantiate(enemyPrefabs, spawnPosition4, enemyPrefabs.transform.rotation);
        }
    }
    
}
