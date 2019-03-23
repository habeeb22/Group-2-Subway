using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinsX2Text : MonoBehaviour
{
    public Text x2;
    // Start is called before the first frame update
    void Start()
    {
        //PlayerPrefs.SetInt("CoinsX2", PlayerPrefs.GetInt("CoinsX2") + 1);
    }

    // Update is called once per frame
    void Update()
    {
        x2.text = "      X2  " + PlayerPrefs.GetInt("CoinsX2");
    }
}
