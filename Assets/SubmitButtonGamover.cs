using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubmitButtonGamover : MonoBehaviour
{
    public GameManager submitScor;
    public GameObject hideSubmit;
    public GameObject enterText;
    
    // Start is called before the first frame update
    void Start()
    {
        submitScor = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        

    }
    public void submitForScore()
    {
        submitScor.SubmitScore();
        //hideSubmit.SetActive(false);
        //enterText.SetActive(false);
    }
}
