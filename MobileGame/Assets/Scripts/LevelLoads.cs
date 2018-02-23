using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoads : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log("Starting Up");
	}
	
	// Update is called once per frame
	void Update () {
		 
	}

    void OnTriggerEnter2D (Collider2D collision)
    {
        //Loading in the easy levels 
        //at completeion of the previous level
        if (collision.gameObject.name == "FlagE1")
        {
            SceneManager.LoadScene("Lvl2E");
        }

        if (collision.gameObject.name == "FlagE2")
        {
            SceneManager.LoadScene("Lvl3E");
        }

        //Loading in the medium levels 
        //at completeion of the previous level
        if (collision.gameObject.name == "FlagM1")
        {
            SceneManager.LoadScene("Lvl2M");
        }

        if (collision.gameObject.name == "FlagM2")
        {
            SceneManager.LoadScene("Lvl3M");
        }

        //Loading in the hard levels 
        //at completeion of the previous level
        if (collision.gameObject.name == "FlagH1")
        {
            SceneManager.LoadScene("Lvl2H");
        }

        if (collision.gameObject.name == "FlagH2")
        {
            SceneManager.LoadScene("Lvl3H");
        }


    }
    
}
