using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{

    public float control_speed;
    public float speed;
    public float slide;
    public Rigidbody rb;

    //public Vector3 move_direction = GameObject.;

    void Slide()
    {
        if (Input.GetKeyUp("w")) // up
        {
            rb.AddForce(transform.up * slide, ForceMode.Impulse);
        }

        if (Input.GetKeyUp("a")) // left
        {
            rb.AddForce(transform.right * -slide, ForceMode.Impulse);
        }

        if (Input.GetKeyUp("s")) // down
        {
            rb.AddForce(transform.up * -slide, ForceMode.Impulse);
        }

        if (Input.GetKeyUp("d")) // right
        {
            rb.AddForce(transform.right * slide, ForceMode.Impulse);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        //rb.AddForce(transform.forward * speed, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {

        // moves player forward on the Z axis

        //transform.Translate(transform.forward * control_speed * Time.deltaTime);
        transform.Translate(transform.forward * speed * Time.deltaTime);

        //transform.position = transform.position + cam.transform.forward * speed * Time.deltaTime; //works :')

        // Movement 

        if (Input.GetKey("w")) // up
        {
            transform.Translate(transform.up * control_speed * Time.deltaTime); 
            //rb.AddForce(transform.up * speed, ForceMode.Impulse);
        }

        if (Input.GetKey("a")) // left
        {
            transform.Translate(transform.right * -control_speed * Time.deltaTime);
            //rb.AddForce(transform.right * -speed, ForceMode.Impulse);
        }

        if (Input.GetKey("s")) // down
        {
            transform.Translate(transform.up * -control_speed * Time.deltaTime);
            //rb.AddForce(transform.up * -speed, ForceMode.Impulse);
        }

        if (Input.GetKey("d")) // right
        {
            transform.Translate(transform.right * control_speed * Time.deltaTime);
            //rb.AddForce(transform.right * speed, ForceMode.Impulse);
        }

        Slide();
    }
}
