using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementWithFeet : MonoBehaviour {

    public float moveSpeed = 3.0f;
    public float jumpSpeed = 3.0f;
    private bool grounded = false;
    private bool DoubleJump;
    Animator anim;

    // Use this for initialization
    void Start()
    {
        DoubleJump = false;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        float moveX = Input.GetAxis("Horizontal");
        Vector2 velocity = GetComponent<Rigidbody2D>().velocity;
        velocity.x = moveSpeed * moveX;
        GetComponent<Rigidbody2D>().velocity = velocity;

        if (Input.GetButtonDown("Jump") && grounded)
        {
            anim.SetBool("isJump", true);
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 100 * jumpSpeed));
        }

        if (Input.GetButtonDown("Jump") && !grounded && !DoubleJump)
        {
            anim.SetBool("isJump", true);
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 50 * jumpSpeed));
            DoubleJump = true;
        }

    }


    public void Grounded ()
    {
        grounded = true;
        anim.SetBool("isJump", false);
        DoubleJump = false;
        anim.SetBool("OnFloor", true);
    }

    public void NotGrounded ()
    {
        grounded = false;
        anim.SetBool("OnFloor", false);
    }





}
