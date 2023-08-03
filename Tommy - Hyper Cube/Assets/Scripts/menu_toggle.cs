using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Runtime.CompilerServices;

public class menu_toggle : MonoBehaviour // make sure to set your OnSelect method to public!
{
    public Toggle toggle_normal;
    public Toggle toggle_medium;
    public Toggle toggle_hard;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetFloat("max_resets", -1f);
        PlayerPrefs.SetString("difficulty", "normal");
        Debug.Log("difficulty_name normal");
    }

    public void normal_toggle()
    {
        PlayerPrefs.SetFloat("max_resets", -1f);
        PlayerPrefs.SetString("difficulty", "normal");
        Debug.Log("difficulty_name normal");
    }

    public void medium_toggle()
    {
        PlayerPrefs.SetFloat("max_resets", 3f);
        PlayerPrefs.SetString("difficulty", "medium");
        Debug.Log("difficulty_name medium");
    }

    public void hard_toggle()
    {
        PlayerPrefs.SetFloat("max_resets", 1f);
        PlayerPrefs.SetString("difficulty", "hard");
        Debug.Log("difficulty_name hard");
    }
}
