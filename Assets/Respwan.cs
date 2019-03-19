using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respwan : MonoBehaviour
{
    public Transform respwanR;
    public Transform respwanM;
    public Transform respwanL;
    float time = 1;
    public GameObject wall1;
    public GameObject wall2;
    public GameObject wall3;
    int randNumR;
    int randNumM;
    int randNumL;
    int randNumW;
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        if (time <=0)
        {
            time = 1;
            Instantiate(wall1, respwanL.position, transform.rotation);
            randNumW = Random.Range(0, 2);
            if (randNumW==0)
            {
                randNumR = Random.Range(0, 10);
                if (randNumR > 6)
                {


                }

            }
            if (randNumR > 6)
            {

                Instantiate(wall1, respwanL.position, transform.rotation);


            }
            //if (randNumM == 4 || randNum == 5 || randNum == 6)
            //{
            //    Instantiate(Coins, new Vector3(1, 0.8f, planPosition.position.z + -6f), planPosition.rotation);
            //    Instantiate(Coins, new Vector3(1, 0.8f, planPosition.position.z + -4f), planPosition.rotation);
            //    Instantiate(Coins, new Vector3(1, 0.8f, planPosition.position.z + -2f), planPosition.rotation);
            //    Instantiate(Coins, new Vector3(1, 0.8f, planPosition.position.z + 0f), planPosition.rotation);
            //    Instantiate(Coins, new Vector3(1, 0.8f, planPosition.position.z + 2f), planPosition.rotation);
            //    Instantiate(Coins, new Vector3(1, 0.8f, planPosition.position.z + 4f), planPosition.rotation);
            //    Instantiate(Coins, new Vector3(1, 0.8f, planPosition.position.z + 6f), planPosition.rotation);
            //}
            //if (randNumL == 6 || randNum == 3)
            //{
            //    Instantiate(Coins, new Vector3(0, 0.8f, planPosition.position.z + -6f), planPosition.rotation);
            //    Instantiate(Coins, new Vector3(0, 0.8f, planPosition.position.z + -4f), planPosition.rotation);
            //    Instantiate(Coins, new Vector3(0, 0.8f, planPosition.position.z + -2f), planPosition.rotation);
            //    Instantiate(Coins, new Vector3(0, 0.8f, planPosition.position.z + 0f), planPosition.rotation);
            //    Instantiate(Coins, new Vector3(0, 0.8f, planPosition.position.z + 2f), planPosition.rotation);
            //    Instantiate(Coins, new Vector3(0, 0.8f, planPosition.position.z + 4f), planPosition.rotation);
            //    Instantiate(Coins, new Vector3(0, 0.8f, planPosition.position.z + 6f), planPosition.rotation);
            //    Instantiate(Coins, new Vector3(1, 0.8f, planPosition.position.z + -6f), planPosition.rotation);
            //    Instantiate(Coins, new Vector3(1, 0.8f, planPosition.position.z + -4f), planPosition.rotation);
            //    Instantiate(Coins, new Vector3(1, 0.8f, planPosition.position.z + -2f), planPosition.rotation);
            //    Instantiate(Coins, new Vector3(1, 0.8f, planPosition.position.z + 0f), planPosition.rotation);
            //    Instantiate(Coins, new Vector3(1, 0.8f, planPosition.position.z + 2f), planPosition.rotation);
            //    Instantiate(Coins, new Vector3(1, 0.8f, planPosition.position.z + 4f), planPosition.rotation);
            //    Instantiate(Coins, new Vector3(1, 0.8f, planPosition.position.z + 6f), planPosition.rotation);
            //    Instantiate(Coins, new Vector3(-1, 0.8f, planPosition.position.z + -6f), planPosition.rotation);
            //    Instantiate(Coins, new Vector3(-1, 0.8f, planPosition.position.z + -4f), planPosition.rotation);
            //    Instantiate(Coins, new Vector3(-1, 0.8f, planPosition.position.z + -2f), planPosition.rotation);
            //    Instantiate(Coins, new Vector3(-1, 0.8f, planPosition.position.z + 0f), planPosition.rotation);
            //    Instantiate(Coins, new Vector3(-1, 0.8f, planPosition.position.z + 2f), planPosition.rotation);
            //    Instantiate(Coins, new Vector3(-1, 0.8f, planPosition.position.z + 4f), planPosition.rotation);
            //    Instantiate(Coins, new Vector3(-1, 0.8f, planPosition.position.z + 6f), planPosition.rotation);
            //}
            //if (randNum < 3)
            //{
            //    Instantiate(Coins, new Vector3(-1, 0.8f, planPosition.position.z + -6f), planPosition.rotation);
            //    Instantiate(Coins, new Vector3(-1, 0.8f, planPosition.position.z + -4f), planPosition.rotation);
            //    Instantiate(Coins, new Vector3(-1, 0.8f, planPosition.position.z + -2f), planPosition.rotation);
            //    Instantiate(Coins, new Vector3(-1, 0.8f, planPosition.position.z + 0f), planPosition.rotation);
            //    Instantiate(Coins, new Vector3(-1, 0.8f, planPosition.position.z + 2f), planPosition.rotation);
            //    Instantiate(Coins, new Vector3(-1, 0.8f, planPosition.position.z + 4f), planPosition.rotation);
            //    Instantiate(Coins, new Vector3(-1, 0.8f, planPosition.position.z + 6f), planPosition.rotation);
            //}

        }
    }
}
