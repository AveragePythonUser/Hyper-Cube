using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change_fov : MonoBehaviour
{
    public float change_time;
    public float target_FOV;
    private float starting_FOV = Camera.main.fieldOfView;
    private bool changing_FOV = false;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(time_start());
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
