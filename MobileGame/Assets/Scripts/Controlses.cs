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
            Debug.Log("Mobile");
        }

        if (PlayerPrefs.GetInt("OnPc") == 0)
        {
            Debug.Log("PC");
        }
    }
}
