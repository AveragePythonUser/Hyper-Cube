using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class hud_and_pause : MonoBehaviour
{

    public GameObject HUD;
    public GameObject pause_menu;
    public GameObject controls;
    // Start is called before the first frame update
    void Start()
    {
        pause_menu.SetActive(false);
        controls.SetActive(false);
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

    public void main_menu_button()
    {
        pause_menu.SetActive(false);
        controls.SetActive(false);
        PlayerPrefs.SetFloat("player_resets", 0);
        // make sure to set timescale to 1 when changing scenes
        // if you dont stuff breaks
        resume_game();
        SceneManager.LoadScene("main_menu");
    }

    public void controls_button()
    {
        pause_menu.SetActive(false);
        controls.SetActive(true);
    }

    public void done_button()
    {
        controls.SetActive(false);
        pause_menu.SetActive(true);
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
