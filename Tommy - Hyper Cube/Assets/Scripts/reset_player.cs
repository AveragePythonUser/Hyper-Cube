using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class reset_player : MonoBehaviour
{
    public string scene_name;
    public bool goal;
    public static bool momentum;

    private void Start()
    {
        if(scene_name == "")
        {
            scene_name = SceneManager.GetActiveScene().name;
        }
/*        else if(scene_name == "goal")
        {
            scene_name = SceneManager.GetActiveScene().name;
        }*/
    }
    private void OnCollisionEnter(Collision collision)
    {
        
        if(collision.gameObject.CompareTag("Player"))
        {
            if (goal == true)
            {
                momentum = true;
            }
            else
            {
                momentum = false;
                PlayerPrefs.SetFloat("player_resets", PlayerPrefs.GetFloat("player_resets") + 1);
            }
            Debug.Log(PlayerPrefs.GetFloat("player_resets"));
            SceneManager.LoadScene(scene_name);
        }
    }
}
