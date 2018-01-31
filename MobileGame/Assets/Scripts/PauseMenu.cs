using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    public GameObject Menus;

    public void Pause ()
    {
        Time.timeScale = 0;
        Menus.GetComponent<Canvas>().enabled = true;

    }

    public void Resume ()
    {
        Time.timeScale = 1;
        Menus.GetComponent<Canvas>().enabled = false;
    }

    public void MainMenu ()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Exit ()
    {
        Application.Quit();
    }
}
