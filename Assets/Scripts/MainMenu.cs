using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject OptionsMenu;

    public void Options()
    {
        OptionsMenu.SetActive(true);
    }

    public void DisabledOptions()
    {
        OptionsMenu.SetActive(false);
    }

    public void LoadGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void quit()
    {
        Application.Quit();
    }
}
