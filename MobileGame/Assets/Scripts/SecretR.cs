using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecretR : MonoBehaviour {

    public GameObject Wall;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "WallTrig")
        {
            Wall.GetComponent<Canvas>().enabled = false;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.name == "WallTrig")
        {
            Wall.GetComponent<Canvas>().enabled = false;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "WallTrig")
        {
            Wall.GetComponent<Canvas>().enabled = true;
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
