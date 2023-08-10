using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class win : MonoBehaviour
{
    private string remaining_resets;
    public Text reset_text;
    public GameObject text;
    private string difficulty_resets;
    // Start is called before the first frame update
    void Start()
    {

        if (PlayerPrefs.GetString("Difficulty") == "normal")
        {
            text.SetActive(false);
        }
        else if (PlayerPrefs.GetString("Difficulty") == "medium")
        {
            difficulty_resets = "3";
        }
        else if (PlayerPrefs.GetString("Difficulty") == "hard")
        {
            difficulty_resets = "1";
        }

        remaining_resets = "/" + (PlayerPrefs.GetFloat("max_resets") - PlayerPrefs.GetFloat("player_resets")).ToString();

        reset_text.text = "Resets: " + remaining_resets + difficulty_resets;
    }
}
