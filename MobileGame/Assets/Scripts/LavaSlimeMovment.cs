using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaSlimeMovment : MonoBehaviour {

    public Vector3 paceDirection = new Vector3(0f, 0f, 0f);
    public float paceDistance = 3.0f;
    private Vector3 startPosition;
    public float chaseSpeed = 2.0f;

    // Use this for initialization
    void Start () {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update () {
        Vector3 displacement = transform.position - startPosition;
        float distanceFromStart = displacement.magnitude;
        if (distanceFromStart >= paceDistance)
        {
            //do stuff, we've gone too far
            paceDirection = -displacement;
        }
        if(GetComponent<SpriteRenderer>().flipX && GetComponent<Rigidbody2D>().velocity.x > 0)
        {
            GetComponent<SpriteRenderer>().flipX = !GetComponent<SpriteRenderer>().flipX;
        }
        if(!GetComponent<SpriteRenderer>().flipX && GetComponent<Rigidbody2D>().velocity.x < 0)
        {
            GetComponent<SpriteRenderer>().flipX = !GetComponent<SpriteRenderer>().flipX;
        }
            paceDirection.Normalize();
        GetComponent<Rigidbody2D>().velocity = paceDirection * chaseSpeed;
    }
}
