using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] obstacles;//ENCAPSULATION
    private float lowerLimmit = -0.75f;
    private float upperLimmit = 5.75f;
    private float startDelay = 2.0f;
    private float spawnInterval = 1.5f;
    private PlayerController playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, spawnInterval);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void SpawnObstacle()
    {
        if (playerControllerScript.gameOver == false)
        {
            float yPos = UnityEngine.Random.Range(lowerLimmit, upperLimmit);
            Vector3 spawnPos = new Vector3(0, yPos, 0);
            int obstacleNumber = UnityEngine.Random.Range(0, obstacles.Length);
            Instantiate(obstacles[obstacleNumber], spawnPos, obstacles[obstacleNumber].transform.rotation);
        }
    }
}
