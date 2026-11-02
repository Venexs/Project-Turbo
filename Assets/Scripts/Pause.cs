using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public GameObject PauseMenu;
    public GameObject Option;
    public GameObject QuitUI;

    public static bool GameIsPaused = true;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
                {
                pause();
                } else
                {
                Resume();
                }
        }
    }

    public void pause()
    {
        PauseMenu.SetActive(true);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Resume()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void Menu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main Menu");
    }

    public void OptionOn()
    {
        Option.SetActive(true);
    }

    public void OptionOff()
    {
        Option.SetActive(false);
    }

    public void Quit()
    {
        Application.Quit();
    }

}
