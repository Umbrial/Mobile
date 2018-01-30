using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementWithFeet : MonoBehaviour {

    public float moveSpeed = 3.0f;
    public float jumpSpeed = 3.0f;
    private bool grounded = false;
    private bool DoubleJump;
    //Animator anim;

    // Use this for initialization
    void Start()
    {
        DoubleJump = false;
        //anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

       /* //the player pref helps to tranfer a bool across scripts
        PlayerPrefs.GetInt("Ground");

        if (PlayerPrefs.GetInt("Ground") == 1)
        {
            grounded = true;
            DoubleJump = false;
        }

        if (PlayerPrefs.GetInt("Ground") == 0)
        {
            grounded = false;
        } */


        float moveX = Input.GetAxis("Horizontal");
        Vector2 velocity = GetComponent<Rigidbody2D>().velocity;
        velocity.x = moveSpeed * moveX;
        GetComponent<Rigidbody2D>().velocity = velocity;

        if (Input.GetButtonDown("Jump") && grounded)
        {
            //anim.SetBool("isJump", true);
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 100 * jumpSpeed));
        }

        if (Input.GetButtonDown("Jump") && !grounded && !DoubleJump)
        {
            //anim.SetBool("isJump", true);
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 50 * jumpSpeed));
            DoubleJump = true;
        }

    }
/*
    void OnCollisionEnter2D(Collision2D collision)
    {
        //if we collide with anything on the ground layer we are grounded
        //layer 8 is our ground layer
        if (collision.gameObject.layer == 8)
        {
            grounded = true;
        }
    }
    void OnCollisionExit2D(Collision2D collision)
    { 
        //if we stop coliding with something on the ground layer no jumps
        if (collision.gameObject.layer == 8)
        {
            grounded = false;
        }

    }
    void OnCollisionStay2D(Collision2D collision)
    {
        //if we stay colliding with something on ground layer, we can jump
        if (collision.gameObject.layer == 8)
        {
            grounded = true;
        }
    }  */

    public void Grounded ()
    {
        grounded = true;
        //anim.SetBool("isJump", false);
        DoubleJump = false;
    }

    public void NotGrounded ()
    {
        grounded = false;
    }





}
