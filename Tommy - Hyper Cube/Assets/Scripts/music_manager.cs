using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class music_manager : MonoBehaviour
{

    void Awake()
    {

        GameObject[] music = GameObject.FindGameObjectsWithTag("Music");
        
        if (music.Length > 1)
        {
            Destroy(this.gameObject);
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
        }
        
    }
}
