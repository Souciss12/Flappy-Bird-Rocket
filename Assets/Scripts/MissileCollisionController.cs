using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileCollisionController : MonoBehaviour
{
    public ParticleSystem SFX;
    private LogicScript logic;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "button")
        {
            PipeDownScript pipeDownScript = collision.transform.parent?.GetComponent<PipeDownScript>();

            if (pipeDownScript != null)
            {
                pipeDownScript.Down();
            }
            logic.button();
            logic.missileExplosion(transform);
            
            Destroy(gameObject);
        }
        else if(collision.gameObject.tag == "pipe" || collision.gameObject.tag == "pipeDown")
        {
            logic.missileExplosion(transform);
            Destroy(gameObject);
        }
        
    }
}
