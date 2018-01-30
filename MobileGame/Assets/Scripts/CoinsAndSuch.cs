using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinsAndSuch : MonoBehaviour
{

    //these are for the image canvas'
    public GameObject Muns;
    public GameObject Gemas;
    public GameObject Stary;
    public GameObject Starry;
    public GameObject ScoreBoard;

    //Counting the collectables
    private int CoinCount = 0;
    private int GemCount = 0;
    private int StarCount = 0;
    private int Score = 0;
    //Gems are worth 24 points
    private int GemP = 0;
    //Stars are worth 44 points
    private int StarP = 0;

    //Display Helper
    private bool Star1;
    private bool Star2;

    public float timer;

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        Gemas.GetComponent<Text>().text = "Time: " + Mathf.RoundToInt(timer);

        //PlayerPrefs.SetInt("Gems", GemCount);

        //PlayerPrefs.SetInt("Coins", CoinCount);

        if (Star1 == true)
        {
            //1 = true
            PlayerPrefs.SetInt("Star1", 1);
        }

        if (Star2 == true)
        {
            PlayerPrefs.SetInt("Star2", 1);
        }

        Score = CoinCount + GemP + StarP;

        GemP = 24 * GemCount;

        StarP = 44 * StarCount;

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

        //if you run into a star gem you collect it
        //and the appropriate star image is displayed
        if (collision.gameObject.name == "Star")
        {
            Destroy(collision.gameObject);
            Starry.GetComponent<Image>().enabled = true;
            StarCount += 1;
            Star1 = true;
        }

        //if you run into a gem, you collect it, it is displayed
        if (collision.gameObject.name == "Gem")
        {
            Destroy(collision.gameObject);
            GemCount += 1;
            //Gemas.GetComponent<Image>().enabled = true;
        }

        //if you run into a star gem you collect it
        //and the appropriate star image is displayed
        if (collision.gameObject.name == "Stars")
        {
            Destroy(collision.gameObject);
            StarCount += 1;
           Stary.GetComponent<Image>().enabled = true;
            Star2 = true;
        }

        
    }
}
