using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{

    public float speed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        // moves player forward on the Z axis

        transform.Translate(transform.forward * speed * Time.deltaTime);

        // Movement 

        if(Input.GetKey("w")) // up
        {
            transform.Translate(transform.up * speed * Time.deltaTime);
        }

        if (Input.GetKey("a")) // left
        {
            transform.Translate(transform.right * -speed * Time.deltaTime);
        }

        if (Input.GetKey("s")) // down
        {
            transform.Translate(transform.up * -speed * Time.deltaTime);
        }

        if (Input.GetKey("d")) // right
        {
            transform.Translate(transform.right * speed * Time.deltaTime);
        }
    }
}
