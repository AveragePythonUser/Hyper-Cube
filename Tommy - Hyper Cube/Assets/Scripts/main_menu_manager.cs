using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using static object_button;

public class main_menu_manager : MonoBehaviour
{

    public string scene_name;

    public GameObject main_panel;
    private GameObject selected_panel;
    public GameObject main_menu_cubes;
    public GameObject difficulty_panel;
    public GameObject credits_panel;

    public void Start()
    {
        
        difficulty_panel.SetActive(false);
        credits_panel.SetActive(false);

    }

    public void reset_panels()
    {
        difficulty_panel.SetActive(false);
        credits_panel.SetActive(false);
    }

    public void change_panel(GameObject panel_name)
    {
        main_panel.SetActive(false);
        reset_panels();

        panel_name.SetActive(true);

        // if (panel_name == "Main Panel")
        // {
        //     main_panel.SetActive(true);
        // }
        // if (panel_name == "Difficulty Panel")
        // {
        //     difficulty_panel.SetActive(true);
        //     main_menu_cubes.SetActive(false);
        // }
    }

/*    public void load_scene(string scene_name)
    {
        SceneManager.LoadScene(scene_name);
    }*/
}
