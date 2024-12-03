using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileMoveScript : MonoBehaviour
{
    public float MissileSpeed;

    void Update()
    {
        transform.position = transform.position + (Vector3.left * MissileSpeed) * Time.deltaTime;
    }
}
