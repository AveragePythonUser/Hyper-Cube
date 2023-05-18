using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change_fov : MonoBehaviour
{
    public float change_time;
    public float target_FOV;
    private float starting_FOV;
    private bool changing_FOV = false;
    
    // Start is called before the first frame update
    void Start()
    {
        if (reset_player.momentum == false)
        {
            starting_FOV = Camera.main.fieldOfView;
            StartCoroutine(time_start());
        }
        else
        {
            //Camera.main.fieldOfView = target_FOV;
            starting_FOV = target_FOV - 10;
            Camera.main.fieldOfView = starting_FOV;
            change_time = 1;
            StartCoroutine(time_start());
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(changing_FOV == true)
        {
            Camera.main.fieldOfView += ((target_FOV / change_time) - (starting_FOV / change_time)) * Time.deltaTime;
        }
    }

    IEnumerator time_start()
    {
        changing_FOV = true;
        yield return new WaitForSeconds(change_time); 
        changing_FOV = false;
    }
}
