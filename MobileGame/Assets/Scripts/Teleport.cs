﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour {

    
    public Vector3[] positions;
    private int index = 0;

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update () {
        Vector3 dist = transform.position - GameObject.Find("CameraObj").transform.position;
        if(dist.magnitude < 1 && index < positions.Length - 1)
        {
            index++;
            transform.position = positions[index];
            Debug.Log("Were on: " + index);
        }
		
      
	}
}
