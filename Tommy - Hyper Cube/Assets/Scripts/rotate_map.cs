using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate_map : MonoBehaviour
{
    //
    // Used to rotate player but I was getting a lot of problems with the movement and stuff
    // so I decided to just rotate the entire map instead.
    //
    public GameObject map;
    public GameObject point;
    public float degrees;
    public float journey_time = 1f;
    public Vector3 vector_axis;

    public float start_time;
    public bool rotating = false;

    void Start()
    {
        start_time = Time.time;
    }

    void Update()
    {
        if (rotating == true)
        {
            Vector3 center_point = point.transform.position;

            center_point = new Vector3(0, 1, 0);

            Vector3 map_relative_center = map.transform.position - center_point;
            Vector3 end_point = center_point + vector_axis;

            float fraction_complete = (Time.time - start_time) / journey_time;

            map.transform.position = Vector3.Slerp(map_relative_center, end_point, fraction_complete);
            map.transform.position += center_point;
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //map.transform.RotateAround(point.transform.position, vector_axis, degrees);
            rotating = true;
        }
    }
}


