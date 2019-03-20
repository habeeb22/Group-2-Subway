using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager1 : MonoBehaviour
{
    public static GameManager1 Instance;
    public Text scoreText;
    public Text scoreTextG;
    public Text bestscoreText;

    bool start;
    public int score;
    public static int coin;
    public Text coinText;
    public Text coinTextG;
    public float bestscore;

    void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(this);

        //DontDestroyOnLoad(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        print(PlayerPrefs.GetInt("Player"));
        score = 0;
        coin = 0;
        scoreText.text = "score: " + 0;
    }

    // Update is called once per frame
    void Update()
    {

        //GameObject.FindGameObjectWithTag("GameStarted").GameStart();
        //if (start == true)
        //{
        score += 1;
        //PlayerPrefs.SetInt("player", score);

        //}

        //GameObject.FindGameObjectWithTag(!"GameStarted").GameStop();

        scoreText.text = "score: " + score;
        scoreTextG.text = "score: " + score;
        bestscoreText.text = "BestScore: " + bestscore;
        coinText.text = "Coin: " + coin;
        coinTextG.text = "Coin: " + coin;




        if ( PlayerPrefs.GetInt("Player") < score )

        {
            bestscore = score;
            bestscoreText.text = "BestScore: " + score;
            PlayerPrefs.SetInt("Player",score);
 }
        else
            bestscoreText.text = "BestScore: " + PlayerPrefs.GetInt("Player");
    }

    //public void GameStart()
    //{
    //    start = true;
    //    //score += 1;
    //}
    //public void GameStop()
    //{
    //    start = false;
    //    //score += 1;
    //}
}
