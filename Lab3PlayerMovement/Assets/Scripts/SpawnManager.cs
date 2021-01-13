using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] rockPrefabs;
    private float spawnRangeX = 15.0f;
    private float spawnRangeZ = 15.0f;

    public string gameOver = "F";

    

    public float startDelay = 2.0f;
    public float spawnInterval = 2.0f;
    public float score = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRock", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        if(gameOver == "T")
        {
            print("GAME OVER! Your score is " + score + ".");
            Time.timeScale = 0;
            gameOver = "D";
        }
    }

    void SpawnRock()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 1.76f, Random.Range(-spawnRangeZ, spawnRangeZ));

        int rockIndex = Random.Range(0, rockPrefabs.Length);
        Instantiate(rockPrefabs[rockIndex], spawnPos, rockPrefabs[rockIndex].transform.rotation);
    }



}
