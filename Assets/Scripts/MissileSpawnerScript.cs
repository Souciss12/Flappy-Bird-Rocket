using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class MissileSpawnerScript : MonoBehaviour
{
    public GameObject bird;
    public GameObject missile;
    private LogicScript logic;
    public AudioSource missileLaunch;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0) && logic.birdAlive) 
        {
            SpawnMissile();
            missileLaunch.Play();
        }
    }

    void SpawnMissile()
    {
        float posX = bird.transform.position.x + 1;
        float posY = bird.transform.position.y - 2;

        Instantiate(missile, new Vector3(posX, posY), missile.transform.rotation);
    }
}
