using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using static main_menu_manager;

public class object_button : MonoBehaviour
{

    //
    // Controls things like hover effects and user input in menu cubes
    // this was surprisingly difficult to make
    //

    public main_menu_manager main_menu_manager;

    private bool mouse_on;
    private float scale;
    public string panel_change;
    public float smooth_time;
    private float vel;
    public float scale_ratio = 1.25f;
    private float max;
    private float min;
    // Start is called before the first frame update
    void Start()
    {
        min = transform.localScale.x;
        max = (min * scale_ratio);
    }

    // getting this to work has been a bit of a nightmare
    // finally got it working. still dont really know how it works
    // credit to these forum posts for helping me figure out all the scaling junk
    // https://forum.unity.com/threads/scaling-object-using-lerp.411289/
    // https://forum.unity.com/threads/smooth-scaling.8614/
    void Update()
    {
        if (mouse_on == true)
        {
            scale = Mathf.SmoothDamp(transform.localScale.x, max, ref vel, smooth_time);
            transform.localScale = new Vector3(scale, scale, scale);
        }
        else
        {
            scale = Mathf.SmoothDamp(transform.localScale.x, min, ref vel, smooth_time);
            transform.localScale = new Vector3(scale, scale, scale);
        }
    }

    void OnMouseDown()
    {
        Debug.Log("mouse down");
        main_menu_manager.change_panel(panel_change);
    }

    void OnMouseEnter()
    {
        mouse_on = true;
    }

    void OnMouseExit()
    {
        mouse_on = false;
    }
}
