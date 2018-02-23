using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
public class AnimControl : MonoBehaviour {

    Animator anim;


	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

        //Get axis raw gives us baase values, ignoring how long
        //the button has been pressed, so we only get -1, 1, or 0
        float moveX = CrossPlatformInputManager.GetAxisRaw("Horizontal");
        anim.SetFloat("x", moveX);
        
        //if moveX = 0 we are not getting any user input
        //so we are not walking, tell the animator
        if(moveX == 0)
        {
            anim.SetBool("isWalking", false);
        } else
        {
            anim.SetBool("isWalking", true);
        }
        /* if(PlayerPrefs.GetInt("Jumping") == 1)
        {
            anim.SetBool("isJump", true);
        } 
         if(PlayerPrefs.GetInt("Jumping") == 0)
        {
            anim.SetBool("isJump", false);
        } */

	}
}
