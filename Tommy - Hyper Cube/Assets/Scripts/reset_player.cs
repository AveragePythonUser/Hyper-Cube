using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class reset_player : MonoBehaviour
{
    public string scene_name;

    private void Start()
    {
        if(scene_name == "")
        {
            scene_name = SceneManager.GetActiveScene().name;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        
        if(collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(scene_name);
        }
    }
}
