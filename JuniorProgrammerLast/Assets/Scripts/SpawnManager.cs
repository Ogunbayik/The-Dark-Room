using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] enemiesPrefab;
    [SerializeField] private float startTime = 2.0f;
    [SerializeField] private float continueTime = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
            InvokeRepeating("SpawnRandomEnemy", startTime, continueTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private Vector3 RandomLocation()
    {
        float xRange = 15;
        float zRange = 15;
        float randomX = Random.Range(-xRange, xRange);
        float yPosition = 5f;
        float randomZ = Random.Range(-zRange, zRange);

        Vector3 spawnPoint = new Vector3(randomX, yPosition, randomZ);
        return spawnPoint;
    }

    void SpawnRandomEnemy()
    {
        int randomIndex = Random.Range(0, 3);
        if(FindObjectOfType<GameManager>().gameIsOver == false)
        Instantiate(enemiesPrefab[randomIndex], RandomLocation(), Quaternion.identity);
    }

    
   
}
