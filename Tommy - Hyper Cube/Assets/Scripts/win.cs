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

        if (PlayerPrefs.GetString("difficulty") == "normal")
        {
            reset_text.text = "Resets: " + PlayerPrefs.GetFloat("player_resets").ToString();
            Debug.Log("normal");
        }
        else if (PlayerPrefs.GetString("difficulty") == "medium")
        {
            reset_text.text = "Resets: " + PlayerPrefs.GetFloat("player_resets").ToString() + "/3";
            Debug.Log("medium");
        }
        else if (PlayerPrefs.GetString("difficulty") == "hard")
        {
            text.SetActive(false);
            Debug.Log("hard");
        }
    }
}
