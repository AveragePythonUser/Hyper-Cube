using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class main_menu_manager : MonoBehaviour
{

    public string scene_name;

    public GameObject main_panel;
    public GameObject difficulty_panel;

    public void Start()
    {
        difficulty_panel.SetActive(false);

    }
    public void load_scene(string scene_name)
    {
        SceneManager.LoadScene(scene_name);
    }
}
