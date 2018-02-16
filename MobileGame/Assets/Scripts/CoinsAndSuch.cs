using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinsAndSuch : MonoBehaviour
{

    //these are for the image canvas'
    public GameObject Muns;
    public GameObject Timey;
    public GameObject ScoreBoard;

    //Counting the collectables
    private int CoinCount = 0;
    private int GemCount = 0;
    //Gems are big coins, worth 5
    private int GemP = 0;
    private int Score;

    public float timer;

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        Timey.GetComponent<Text>().text = "Time: " + Mathf.RoundToInt(timer);

        Score = CoinCount + GemP;

        GemP = 5 * GemCount;

        //StarP = 44 * StarCount;

        //tells you how many coins you have
        Muns.GetComponent<Text>().text = "x " + CoinCount;

        //Keeps track of your score
        ScoreBoard.GetComponent<Text>().text = "Score: " + Score;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //If you run into a coin you collect it
        if (collision.gameObject.tag == "Coin")
        {
            Destroy(collision.gameObject);
            CoinCount += 1;
        }

        //if you run into a big coin you collect it
        if (collision.gameObject.tag == "BigCoin")
        {
            Destroy(collision.gameObject);
        }

    }
}
