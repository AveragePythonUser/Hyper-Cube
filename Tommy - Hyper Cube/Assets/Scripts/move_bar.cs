using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class move_bar : MonoBehaviour
{
    public float speed;
    public string rotate_direction;
    public float modifier = 1f;
    private float x_move = 0;
    private float y_move = 0;
    private float z_move = 0;

    private bool moving = false;
    public float delay = 0;

    void Start() // c sharp not python. dont put : at the end of functions worst mistake of my life
    {
        speed = speed * 500;
        if (rotate_direction == "x")
        {
            x_move = speed * modifier;
        }
        if (rotate_direction == "y")
        {
            y_move = speed * modifier;
        }
        if (rotate_direction == "z")
        {
            z_move = speed * modifier;
        }

        StartCoroutine(wait());
    }

    void Update()
    {
        if (moving == true)
        {
            transform.position += new Vector3(x_move * Time.deltaTime, y_move * Time.deltaTime, z_move * Time.deltaTime);
        }
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(delay);
        moving = true;
    }
}
