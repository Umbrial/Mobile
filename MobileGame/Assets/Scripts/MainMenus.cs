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
        SceneManager.LoadScene("Level4");
    }

    public void Hard()
    {
        SceneManager.LoadScene("Level7");
    }
}
