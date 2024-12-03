using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeDownScript : MonoBehaviour
{
    private bool isDown = false;

    private int moveDown = 5;
    public float MoveTime = 2;
    private float timer = 0;

    private void Update()
    {
        if (isDown)
        {
            if (timer < MoveTime)
            {
                transform.position = transform.position + (Vector3.down * moveDown) * Time.deltaTime;
                timer += Time.deltaTime;
            }
            else
            {
                isDown = false;
            }
        }
    }
    public void Down()
    {
        isDown = true;
    }
}
