using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlosAttack : MonoBehaviour {

    Animator anim2;

    void Start()
    {
        anim2 = GetComponent<Animator>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            anim2.SetBool("SteppedOn", true);
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            anim2.SetBool("SteppedOn", false);
        }
    }
}
