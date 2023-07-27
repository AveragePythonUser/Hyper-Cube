using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Runtime.CompilerServices;

public class menu_toggle : MonoBehaviour, ISelectHandler // make sure to set your OnSelect method to public!
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

    public void OnSelect(BaseEventData eventData) // Make sure to set public
    {
        Debug.Log("normal toggle: ", toggle_normal);
        Debug.Log("medium toggle: ", toggle_medium);
        Debug.Log("hard toggle: ", toggle_hard);
        if (toggle_normal.isOn == true)
        {
            PlayerPrefs.SetFloat("max_resets", -1f);
            PlayerPrefs.SetString("difficulty", "normal");
            Debug.Log("difficulty_name normal");
        }
        else if (toggle_medium.isOn == true)
        {
            PlayerPrefs.SetFloat("max_resets", 3f);
            PlayerPrefs.SetString("difficulty", "medium");
            Debug.Log("difficulty_name medium");
        }
        else if (toggle_hard.isOn == true)
        {
            PlayerPrefs.SetFloat("max_resets", 1f);
            PlayerPrefs.SetString("difficulty", "hard");
            Debug.Log("difficulty_name hard");
        }
    }
}
