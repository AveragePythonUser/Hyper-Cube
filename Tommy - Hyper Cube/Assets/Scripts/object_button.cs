using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using static main_menu_manager;

public class object_button : MonoBehaviour
{
    public main_menu_manager main_menu_manager;

    private bool mouse_on;
    private bool enter;
    public float direction;
    private float size = 0.5f;
    private float scale;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (mouse_on == true)
        {
            scale = 1f * direction;
            Debug.Log(scale);
            transform.localScale += new Vector3(scale, scale, scale);
        }
    }

    void OnMouseDown()
    {
        Debug.Log("mouse down");
        main_menu_manager.change_panel("difficulty_panel");
    }

    void OnMouseEnter()
    {
        if (mouse_on == false && enter == false)
        {
            Debug.Log("mouse over");
            direction = 1;
            enter = true;
            StartCoroutine(hover("enter"));
        }
    }

    void OnMouseExit()
    {
        if (mouse_on == false)
        {
            direction = -1;
            StartCoroutine(hover("exit"));
        }
    }

    IEnumerator hover(string type)
    {
        mouse_on = true;
        yield return new WaitForSeconds(0.3f);
        mouse_on = false;
    }
}
