using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenus : MonoBehaviour {

	public void Easy ()
    {
        SceneManager.LoadScene("Scene1");
    }

    public void Moderate()
    {
        SceneManager.LoadScene("Lvl1M");
    }

    public void Hard()
    {
        SceneManager.LoadScene("Lvl1H");
    }
}
