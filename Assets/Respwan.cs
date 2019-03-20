using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respwan : MonoBehaviour
{
    public Transform respwanR;
    public Transform respwanM;
    public Transform respwanL;
    float time = .4f;
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
        GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 10);

        time -= Time.deltaTime;
        if (time <=0)
        {
            time = 0.4f;
           // Instantiate(wall1, respwanL.position, transform.rotation);
            randNumW = Random.Range(0, 11);
            if (randNumW <3)
            {
                randNumR = Random.Range(0, 11);
                if (randNumR < 3)
                {
                    Instantiate(wall1, respwanR.position, transform.rotation);
                }
                if (randNumR > 3 && randNumR <7)
                {
                    Instantiate(wall2, respwanR.position, transform.rotation);
                }
                if (randNumR > 6)
                {
                    Instantiate(wall3, respwanR.position, transform.rotation);
                }

            }
            if (randNumW > 3 && randNumW < 7)
            {
                randNumM = Random.Range(0, 11);
                if (randNumM < 3)
                {
                    Instantiate(wall1, respwanM.position, transform.rotation);
                }
                if (randNumM > 3 && randNumM < 7)
                {
                    Instantiate(wall2, respwanM.position, transform.rotation);
                }
                if (randNumM > 6)
                {
                    Instantiate(wall3, respwanM.position, transform.rotation);
                }

            }
            if (randNumW > 6)
            {
                randNumL = Random.Range(0, 11);
                if (randNumL < 3)
                {
                    Instantiate(wall1, respwanL.position, transform.rotation);
                }
                if (randNumL > 3 && randNumL < 7)
                {
                    Instantiate(wall2, respwanL.position, transform.rotation);
                }
                if (randNumL > 6)
                {
                    Instantiate(wall3, respwanL.position, transform.rotation);
                }

            }









            //if (randNumR > 6)
            //{

            //    Instantiate(wall1, respwanL.position, transform.rotation);


            //}
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
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Finished")
        {
            Destroy(gameObject);
        }
    }
}
