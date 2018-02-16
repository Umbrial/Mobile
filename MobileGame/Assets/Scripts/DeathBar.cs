using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class DeathBar : MonoBehaviour {

    public float timer = 0.0f;
    private bool hit = false;

    void Update()
    {
        if (hit == true)
        {
            timer += Time.deltaTime;
        }

        if (timer >=  0.8f)
        {
            SceneManager.LoadScene("MainMenu");
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 9)
        {
            SceneManager.LoadScene("MainMenu");
        }

        if (collision.gameObject.tag == "Blossom")
        {
            hit = true;
        }
    }
}
