using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    
     Text scoreName;
     Text enterName;
    public static GameManager Instance;
    Text scoreText;
    public Text scoreTextG;
    public Text bestscoreText;

    bool start;
    public static int score;
    public static int coin;
    public string coinText;
    public Text coinTextG;
    public float bestscore;

    Text gamePlayCoinsText;

    void Awake()
    {
        
       



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
        print(PlayerPrefs.GetInt("Player"));
        score = 0;
        coin = 0;
        scoreText.text = "score: " + 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        if (sceneName == "GamePlay2")
        {
            gamePlayCoinsText = GameObject.FindGameObjectWithTag("CoinGamPlay").GetComponent<Text>();
            scoreText = GameObject.FindGameObjectWithTag("ScoreGamPlay").GetComponent<Text>();
        }
        else if (sceneName == "GameOver")
        {
            scoreName = GameObject.FindGameObjectWithTag("ScoreNameGameOver").GetComponent<Text>();
            enterName = GameObject.FindGameObjectWithTag("InputFieldGameOver").GetComponent<Text>();
            //scoreName.text = enterName.text;
        }
        
        //GameObject.FindGameObjectWithTag("GameStarted").GameStart();
        //if (start == true)
        //{
        //score += 50;
        //PlayerPrefs.SetInt("player", score);

        //}

        //GameObject.FindGameObjectWithTag(!"GameStarted").GameStop();

        scoreText.text = "score: " + score;
        scoreTextG.text = "score: " + score;
        bestscoreText.text = "BestScore: " + bestscore;
        //coinText = "Coin: " + coin;
        coinTextG.text = "Coin: " + coin;
        //scoreName.text = enterName.text;

        gamePlayCoinsText.text = "Coin: " + coin;

        //if (PlayerPrefs.GetInt("Player") > score)
        //{
        //    enterName.enabled = false;
        //}
        //PlayerPrefs.SetString("Player1", enterName.text.ToString());
        //scoreName.text = PlayerPrefs.GetString("Player1");
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (PlayerPrefs.GetInt("Player") < score)

            {

                bestscore = score;
                
                PlayerPrefs.SetInt("Player", score);
                bestscoreText.text = "BestScore: " + score;
                scoreName.text = enterName.text;
                //if (Input.GetKeyDown(KeyCode.Return))
                //{
                //PlayerPrefs.SetString("Player1", enterName.text);
                //}

            }
            else
            {
                bestscoreText.text = "BestScore: " + PlayerPrefs.GetInt("Player");
                // scoreName.text = PlayerPrefs.GetString("Player1");
            }
        }
        


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
