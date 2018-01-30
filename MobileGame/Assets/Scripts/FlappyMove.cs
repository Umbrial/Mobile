using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappyMove : MonoBehaviour {


    public float moveSpeed = 3.0f;
    public float jumpSpeed = 99.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Vector2 move = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        GetComponent<Rigidbody2D>().velocity = move;

        GetComponent<Rigidbody2D>().velocity = move;

        if (Input.anyKeyDown)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpSpeed));
        }

    }
}
