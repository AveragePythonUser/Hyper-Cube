using System.Collections;
using System.Collections.Generic;
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
        speed *= Time.deltaTime;
        if (moving == true)
        {
            transform.position += new Vector3(x_move, y_move, z_move);
        }
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(delay);
        moving = true;
    }
}
