﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeetEnHit : MonoBehaviour {


    // Use this for initialization
    void Start() { 
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Blossom")
        {
            transform.parent.GetComponent<MovementWithFeet>().Bloomings();
        }
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Blossom")
        {
            transform.parent.GetComponent<MovementWithFeet>().Bloomings();
        }
    }
}
