using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeetJump : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            transform.parent.GetComponent<MovementWithFeet>().Grounded();
        }
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            transform.parent.GetComponent<MovementWithFeet>().Grounded();
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            transform.parent.GetComponent<MovementWithFeet>().NotGrounded();
        }
    }

}
