using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HighscoreTable1 : MonoBehaviour
{
    public static HighscoreTable1 Instance;
    public Transform entryContainer;
    public Transform entryTemp;
    //public List<HighscoreEntry> highscoreEntryList;
    public List<Transform> highscoreEntryTransformList;

   
    public void Awake()
    {
        //entryContainer = transform.Find("highscoreEntryContainer");
        //entryTemp = entryContainer.Find("highscoreEntryTemplate");
        entryContainer = GameObject.FindGameObjectWithTag("highscoreEntryContainer").GetComponent<Transform>();
        entryTemp = GameObject.FindGameObjectWithTag("highscoreEntryTemplate").GetComponent<Transform>();

        entryTemp.gameObject.SetActive(false);
        /*
        highscoreEntryList = new List<HighscoreEntry>()
        {
            new HighscoreEntry{score=525554,name="habib"},
            new HighscoreEntry{score=500,name="jamil"},
            new HighscoreEntry{score=554,name="salim"},
            new HighscoreEntry{score=5554,name="ali"},
            new HighscoreEntry{score=59554,name="ana"},
            new HighscoreEntry{score=954,name="you"},
            new HighscoreEntry{score=54,name="me"},
            new HighscoreEntry{score=3002,name="she"},

        };*/

       // AddHighscoreEntry(10000, "CKM");
        string jsonString = PlayerPrefs.GetString("highscoreTable");

        Highscores highscores = JsonUtility.FromJson<Highscores>(jsonString);




        for (int i = 0; i < highscores.highscoreEntryList.Count; i++)
        {
            for (int j = i + 1; j < highscores.highscoreEntryList.Count; j++)
            {
                if (highscores.highscoreEntryList[j].score> highscores.highscoreEntryList[i].score)
                {
                    HighscoreEntry tmp = highscores.highscoreEntryList[i];
                    highscores.highscoreEntryList[i] = highscores.highscoreEntryList[j];
                    highscores.highscoreEntryList[j] = tmp;


                }
            }
        }
        highscoreEntryTransformList = new List<Transform>();
        foreach (HighscoreEntry highscoreEntry  in highscores.highscoreEntryList )
        {
           
            CreateHighScoreEntryTransform(highscoreEntry, entryContainer, highscoreEntryTransformList);
        }

       
        //Highscores highscore = new Highscores { highscoreEntryList = highscoreEntryList };
        //string json = JsonUtility.ToJson(highscore);
        //PlayerPrefs.SetString("highscoreTable", json);
        //PlayerPrefs.Save();
        //Debug.Log(PlayerPrefs.GetString("highscoreTable"));
        //Debug.Log(highscores);

    }
    public void CreateHighScoreEntryTransform(HighscoreEntry HighscoreEntry, Transform container, List<Transform> transformList)
    {
        
        float templatHeight = 80f;

        
        Transform entryTransform = Instantiate(entryTemp, container);


        RectTransform entryRectTransform = entryTransform.GetComponent<RectTransform>();
        entryRectTransform.anchoredPosition = new Vector2(0, -templatHeight * transformList.Count);
        entryTransform.gameObject.SetActive(true);


        int rank = transformList.Count + 1;
        if (rank >= 6)
        {
            entryTransform.gameObject.SetActive(false); ;
        }
        string rankString;
       
            switch (rank)
        {
            default:
                rankString = rank + "TH";
                break;
            case 1:
                rankString = "1ST";
                break;
            case 2:
                rankString = "2ND";
                break;
            case 3:
                rankString = "3RD";
                break;
        }

        entryTransform.Find("PosText").GetComponent<Text>().text = rankString;
        int score = HighscoreEntry.score;
        entryTransform.Find("ScoreText").GetComponent<Text>().text = score.ToString();
        string name = HighscoreEntry.name;
        entryTransform.Find("NameText").GetComponent<Text>().text = name;
       
            transformList.Add(entryTransform);
        
    }

    public void AddHighscoreEntry(int score,string name)
    {
        HighscoreEntry highscoreEntry = new HighscoreEntry { score = score, name = name };
        string jsonString = PlayerPrefs.GetString("highscoreTable");

        Highscores highscores = JsonUtility.FromJson<Highscores>(jsonString);
        highscores.highscoreEntryList.Add(highscoreEntry);

        string json = JsonUtility.ToJson(highscores);
        PlayerPrefs.SetString("highscoreTable", json);
        PlayerPrefs.Save();
    }

    public class Highscores {

        public List<HighscoreEntry> highscoreEntryList;


    }

    [System.Serializable]
    public class HighscoreEntry
    {
        public int score;
        public string name;
    }

    public void Addscores(int scoress, string namess)
    {
        AddHighscoreEntry(scoress, namess);
    }
    // Start is called before the first frame update
    void Start()
    {
        if (Instance == null)
            Instance = this;
        else
        {
            //musicAudioSource.Stop();
            //PlayerPrefs.SetInt("Music", 0);
            Destroy(this);
        }

        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        if (sceneName == "GameOver")
        {
            //entryContainer = transform.Find("highscoreEntryContainer");
            //entryTemp = entryContainer.Find("highscoreEntryTemplate");
            entryContainer = GameObject.FindGameObjectWithTag("highscoreEntryContainer").GetComponent<Transform>();
            entryTemp = GameObject.FindGameObjectWithTag("highscoreEntryTemplate").GetComponent<Transform>();

            entryTemp.gameObject.SetActive(false);
            /*
            highscoreEntryList = new List<HighscoreEntry>()
            {
                new HighscoreEntry{score=525554,name="habib"},
                new HighscoreEntry{score=500,name="jamil"},
                new HighscoreEntry{score=554,name="salim"},
                new HighscoreEntry{score=5554,name="ali"},
                new HighscoreEntry{score=59554,name="ana"},
                new HighscoreEntry{score=954,name="you"},
                new HighscoreEntry{score=54,name="me"},
                new HighscoreEntry{score=3002,name="she"},

            };*/

            // AddHighscoreEntry(10000, "CKM");
            string jsonString = PlayerPrefs.GetString("highscoreTable");

            Highscores highscores = JsonUtility.FromJson<Highscores>(jsonString);




            for (int i = 0; i < highscores.highscoreEntryList.Count; i++)
            {
                for (int j = i + 1; j < highscores.highscoreEntryList.Count; j++)
                {
                    if (highscores.highscoreEntryList[j].score > highscores.highscoreEntryList[i].score)
                    {
                        HighscoreEntry tmp = highscores.highscoreEntryList[i];
                        highscores.highscoreEntryList[i] = highscores.highscoreEntryList[j];
                        highscores.highscoreEntryList[j] = tmp;


                    }
                }
            }
            highscoreEntryTransformList = new List<Transform>();
            foreach (HighscoreEntry highscoreEntry in highscores.highscoreEntryList)
            {
                CreateHighScoreEntryTransform(highscoreEntry, entryContainer, highscoreEntryTransformList);
            }


            //Highscores highscore = new Highscores { highscoreEntryList = highscoreEntryList };
            //string json = JsonUtility.ToJson(highscore);
            //PlayerPrefs.SetString("highscoreTable", json);
            //PlayerPrefs.Save();
            //Debug.Log(PlayerPrefs.GetString("highscoreTable"));
            //Debug.Log(highscores);


        }
        
    }
}
