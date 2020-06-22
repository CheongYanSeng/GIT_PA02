using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public float SpawnTime;
    public GameObject[] obstacles;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SpawnTime += Time.deltaTime;
        if(SpawnTime > 1.5f)
        {
            float xPos = Random.Range(-1.5f, 1.5f);
            int spawned = Random.Range(0, 4);
            Instantiate(obstacles[spawned], new Vector3(xPos, 0, 0), Quaternion.identity);
            SpawnTime = 0;
        }
    }
}
