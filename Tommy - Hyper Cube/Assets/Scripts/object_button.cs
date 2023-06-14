using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using static main_menu_manager;

public class object_button : MonoBehaviour
{
    public main_menu_manager main_menu_manager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        Debug.Log("toes");
        main_menu_manager.change_panel("difficulty_panel");
    }
}
