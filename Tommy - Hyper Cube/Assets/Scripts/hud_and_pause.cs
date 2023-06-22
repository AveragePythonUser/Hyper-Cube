using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hud_and_pause : MonoBehaviour
{

    public GameObject HUD;
    public GameObject pause_menu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void pause_button()
    {
        pause_game();
        HUD.SetActive(false);
        pause_menu.SetActive(true);
    }

    public void resume_button()
    {
        resume_game();
        pause_menu.SetActive(false);
        HUD.SetActive(true);
    }

    void pause_game()
    {
        Time.timeScale = 0;
    }

    void resume_game()
    {
        Time.timeScale = 1;
    }
}
