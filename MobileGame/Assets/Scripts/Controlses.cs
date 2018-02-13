using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controlses : MonoBehaviour
{

    public GameObject Right;
    public GameObject Left;

    // Use this for initialization
    void Start()
    {
        if (PlayerPrefs.GetInt("OnPc") == 1)
        {
            Right.GetComponent<Button>().enabled = false;
            Right.GetComponent<Image>().enabled = false;
            Left.GetComponent<Button>().enabled = false;
            Left.GetComponent<Image>().enabled = false;
        }

        if (PlayerPrefs.GetInt("OnPc") == 0)
        {
            Right.GetComponent<Button>().enabled = true;
            Right.GetComponent<Image>().enabled = true;
            Left.GetComponent<Button>().enabled = true;
            Left.GetComponent<Image>().enabled = true;
        }
    }
}
