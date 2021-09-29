using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawn : MonoBehaviour
{
    public GameObject ObstacleDown;
    public GameObject ObstacleUp;
    private float timer;
    public float spawnTimer;

    public float distanceMin;
    public float distanceMax;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            SpawnNewObstacle();
            timer = spawnTimer;
        }
    }

    private void SpawnNewObstacle()
    {
        Vector3 spawnPositionDown = transform.position + Vector3.down * Random.Range(distanceMin, distanceMax)
    }
       
}
