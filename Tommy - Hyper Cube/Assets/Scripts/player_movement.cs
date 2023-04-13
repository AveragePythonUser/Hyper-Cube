using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{

    public float speed;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(transform.forward * speed, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {

        // moves player forward on the Z axis

        transform.Translate(transform.forward * speed * Time.deltaTime);
        //rb.AddForce(transform.forward * speed, ForceMode.Force);

        // Movement 

        if (Input.GetKeyDown("w")) // up
        {
            //transform.Translate(transform.up * speed * Time.deltaTime);
            rb.AddForce(transform.up * speed, ForceMode.Impulse);
        }

        if (Input.GetKeyDown("a")) // left
        {
            //transform.Translate(transform.right * -speed * Time.deltaTime);
            rb.AddForce(transform.right * -speed, ForceMode.Impulse);
        }

        if (Input.GetKeyDown("s")) // down
        {
            //transform.Translate(transform.up * -speed * Time.deltaTime);
            rb.AddForce(transform.up * -speed, ForceMode.Impulse);
        }

        if (Input.GetKeyDown("d")) // right
        {
            //transform.Translate(transform.right * speed * Time.deltaTime);
            rb.AddForce(transform.right * speed, ForceMode.Impulse);
        }
    }
}
