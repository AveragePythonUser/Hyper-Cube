using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate_bar : MonoBehaviour
{
    public float speed;
    public string rotate_direction;
    private float x_rotate = 0;
    private float y_rotate = 0;
    private float z_rotate = 0;

    void Start() // c sharp not python. dont put : at the end of functions worst mistake of my life
    {
        if(rotate_direction == "x")
        {
            x_rotate = speed;
        }
        if(rotate_direction == "y")
        {
            y_rotate = speed;
        }
        if(rotate_direction == "z")
        {
            z_rotate = speed;
        }
    }

    void Update()
    {
        transform.Rotate(x_rotate, y_rotate, z_rotate);
    }
}
