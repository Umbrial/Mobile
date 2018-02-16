using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {

    private float timer = 0.0f;
    public bool walking;
    public GameObject player;
    public float chaseSpeed = 2.0f;
    public float chaseTriggerDistance = 200f;
    private Vector3 startPosition;
    

    // Use this for initialization
    void Start()
    {
        //assumes script is attached to player, or an animated object
        //anim = GetComponent<Animator>();
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        Vector2 vel = gameObject.GetComponent<Rigidbody2D>().velocity;
        float input_x = vel.x;
        float input_y = vel.y;

        if (timer >= 0.5)
        {
            walking = true;
        }
        
        //anim.SetBool("walking", walking);
        Vector3 playerPosition = player.transform.position;
        Vector2 chaseDirection = new Vector2(playerPosition.x - transform.position.x,
                                                playerPosition.y - transform.position.y);

        if (chaseDirection.magnitude < chaseTriggerDistance && walking == true)
        {
            //player gets too close to the enemy
            chaseDirection.Normalize();
            GetComponent<Rigidbody2D>().velocity = chaseDirection * chaseSpeed;
         }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Finish") 
        {
            chaseSpeed = 0;
           
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            chaseSpeed = 0;
        }
    }

}
