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

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0) && logic.birdAlive) 
        {
            SpawnMissile();
        }
    }

    void SpawnMissile()
    {
        float posX = bird.transform.position.x + 4;
        float posY = bird.transform.position.y;

        Instantiate(missile, new Vector3(posX, posY), missile.transform.rotation);
    }
}
