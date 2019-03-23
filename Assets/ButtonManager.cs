using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonManag()
    {
        if (PlayerPrefs.GetInt("Coins") < 50)
        {
            print("not Coins");
        }
        else
        {
            PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") - 50);
            PlayerPrefs.SetInt("CoinsX2", PlayerPrefs.GetInt("CoinsX2") + 1);
        }
       
    }
}
