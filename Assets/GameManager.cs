using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public HighscoreTable highadder;
    Text manuCoin;
    Text scoreName;
    Text enterName;
    Text mycoins;

    public static GameManager Instance;
    Text scoreText;
    public Text scoreTextG;
    public Text bestscoreText;
    
    bool start;
    public static int score;
    public static int coin;
    
    //public int  totalcoin1;
    Text totalCoinGamplay;
    //public string coinText;
    public Text coinTextG;
    //public float bestscore;

    Text gamePlayCoinsText;

    void Awake()
    {

        //PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") + coin);



    }
    // Start is called before the first frame update
    void Start()
    {
       
        if (Instance == null)
            Instance = this;
        else
            Destroy(this);
        DontDestroyOnLoad(gameObject);
        //print(PlayerPrefs.GetInt("Player1"));
        //print(PlayerPrefs.GetInt("Player"));
        score = 0;
        coin = 0;
       // scoreText.text = "score: " + 0;

    }

    // Update is called once per frame
    void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        if (sceneName == "ManiManu")
        {
            
            manuCoin = GameObject.FindGameObjectWithTag("ManuCoins").GetComponent<Text>();
            //scoreText = GameObject.FindGameObjectWithTag("ScoreGamPlay").GetComponent<Text>();
            //totalCoinGamplay = GameObject.FindGameObjectWithTag("TotalCoinGamePlay").GetComponent<Text>();
            //gamePlayCoinsText.text = "Coin: " + coin;
            //scoreText.text = "score: " + score;
            //totalcoin1 = totalCoin;

            //PlayerPrefs.SetInt("Coins", totalCo
            
            manuCoin.text = "        :  " + PlayerPrefs.GetInt("Coins");


        }
        else if (sceneName == "GamePlay2")
        {
            gamePlayCoinsText = GameObject.FindGameObjectWithTag("CoinGamPlay").GetComponent<Text>();
            scoreText = GameObject.FindGameObjectWithTag("ScoreGamPlay").GetComponent<Text>();
            totalCoinGamplay = GameObject.FindGameObjectWithTag("TotalCoinGamePlay").GetComponent<Text>();
            gamePlayCoinsText.text = "        : " + coin;
            scoreText.text = "score: " + score;
            //totalcoin1 = totalCoin;
           
            //PlayerPrefs.SetInt("Coins", totalCoin);
            totalCoinGamplay.text = "       : " + PlayerPrefs.GetInt("Coins");

            
        }
        else if (sceneName == "GameOver")
        {
            highadder = GameObject.FindGameObjectWithTag("AdderScores").GetComponent<HighscoreTable>();
            //highadder.Addscores(score, name);
            scoreName = GameObject.FindGameObjectWithTag("ScoreNameGameOver").GetComponent<Text>();
            //enterName = GameObject.FindGameObjectWithTag("InputFieldGameOver").GetComponent<Text>();
            bestscoreText = GameObject.FindGameObjectWithTag("BestScore").GetComponent<Text>();
            if (GameObject.FindGameObjectWithTag("EnterName") !=null)
            {
                enterName = GameObject.FindGameObjectWithTag("EnterName").GetComponent<Text>();
            }
           
            
            mycoins= GameObject.FindGameObjectWithTag("TotalCoins").GetComponent<Text>();
            scoreName.text =  PlayerPrefs.GetString("Player1");
            bestscoreText.text = "Your Score: " + PlayerPrefs.GetInt("Player");
            mycoins.text = "       :  " + PlayerPrefs.GetInt("Coins");
            // PlayerPrefs.GetInt("Coins", PlayerPrefs.GetInt("Coins")+ totalCoin);
            //scoreName.text = enterName.text;
            //PlayerPrefs.GetInt("Coins", PlayerPrefs.GetInt("Coins") + coin);
            //for (int i = 1; i <= coin; i++)
            //{
            //    PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") + 1);
            //}

        }

        //GameObject.FindGameObjectWithTag("GameStarted").GameStart();
        //if (start == true)
        //{
        //score += 50;
        //PlayerPrefs.SetInt("player", score);

        //}

        //GameObject.FindGameObjectWithTag(!"GameStarted").GameStop();
        //PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") + totalCoin);


        scoreTextG.text = "score: " + score;
        //bestscoreText.text = "BestScore: " + bestscore;
        //coinText = "Coin: " + coin;
        coinTextG.text = "Coin: " + coin;
        //scoreName.text = enterName.text;
        


        //if (PlayerPrefs.GetInt("Player") > score)
        //{
        //    enterName.enabled = false;
        //}
        //PlayerPrefs.SetString("Player1", enterName.text.ToString());
      

        //if (Input.GetKeyDown(KeyCode.Return))
        //{
           

        //        highadder.Addscores(score, enterName.text);
             
        //        PlayerPrefs.SetInt("Player", score);
            
        //        PlayerPrefs.SetString("Player1", enterName.text);
            
        //}
        


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
    public void SubmitScore()
    {
        highadder.Addscores(score, enterName.text);
     
        PlayerPrefs.SetInt("Player", score);
       
        PlayerPrefs.SetString("Player1", enterName.text);
        score = 0;
    }
}
