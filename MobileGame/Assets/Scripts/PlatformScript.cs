using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformScript : MonoBehaviour {

    //using a player pref to keep a boolean
    //0 means false, 1 means true
    //Keeping track of if the user is on PC
    //Or mobile, to disable the mobile controls

    void Start()
    {
        PlayerPrefs.SetInt("OnPC", 0);
    }

    public void PC()
    {
        PlayerPrefs.SetInt("OnPc", 1);
    }

    public void NotPC ()
    {
        PlayerPrefs.SetInt("OnOc", 0);
    }
}
