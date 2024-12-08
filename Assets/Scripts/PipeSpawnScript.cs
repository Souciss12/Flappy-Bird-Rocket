using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public GameObject munition;

    public float spawnRate = 2;
    private float timer = 0;
    public float heightOffset = 6;

    void Start()
    {
        SpawnPipe();
    }

    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnPipe();
            timer = 0;
        }
    }

    void SpawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(pipe, new Vector3(transform.position.x, UnityEngine.Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
        Instantiate(munition, new Vector3(transform.position.x - 17, UnityEngine.Random.Range(lowestPoint, highestPoint), 0), Quaternion.Euler(0, 0, 90));
    }
}
