using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate_map : MonoBehaviour
{
    // Used to rotate player but I was getting a lot of problems with the movement and stuff
    // so I decided to just rotate the entire map instead.
    //
    public GameObject map;
    public GameObject point;
    public float degrees;
    public Vector3 vector_axis;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            map.transform.RotateAround(point.transform.position, vector_axis, degrees);
        }
        }
}


