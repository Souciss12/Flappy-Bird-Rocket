using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileCollisionController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "button")
        {
            PipeDownScript pipeDownScript = collision.transform.parent?.GetComponent<PipeDownScript>();

            if (pipeDownScript != null)
            {
                pipeDownScript.Down();
            }

            Destroy(gameObject);
        }
        else if(collision.gameObject.tag == "pipe" || collision.gameObject.tag == "pipeDown")
        {
            Destroy(gameObject);
        }
        
    }
}
