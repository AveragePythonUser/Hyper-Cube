using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class music_manager : MonoBehaviour
{

    public AudioSource weaver;
    public AudioSource crane;

    private string scene_name;

    void Awake()
    {

        GameObject[] music = GameObject.FindGameObjectsWithTag("Music");

        if 
        
        if (music.Length > 1)
        {
            Destroy(this.gameObject);
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
        }

        scene_name = SceneManager.GetActiveScene().name;

        if (scene_name == "main_menu")
        {
            crane.Stop();
            weaver.Play();
        }
        else
        {
            weaver.Stop();
            crane.Play();
        }
    }
}
