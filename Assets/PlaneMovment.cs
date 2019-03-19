using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneMovment : MonoBehaviour
{
    public GameObject plane;
    public Transform planPosition;
    public GameObject Coins;
    int randNum;
    public float time=5;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        if (time < 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Instantiate(plane, planPosition.position, transform.rotation);
            randNum = Random.Range(0, 10);
            if (randNum>6)
            {
                Instantiate(Coins, new Vector3(0, 0.8f, planPosition.position.z + -6f), planPosition.rotation);
                Instantiate(Coins, new Vector3(0, 0.8f, planPosition.position.z + -4f),planPosition.rotation);
                Instantiate(Coins, new Vector3(0, 0.8f, planPosition.position.z + -2f), planPosition.rotation);
                Instantiate(Coins, new Vector3(0, 0.8f, planPosition.position.z + 0f), planPosition.rotation);
                Instantiate(Coins, new Vector3(0, 0.8f, planPosition.position.z + 2f), planPosition.rotation);
                Instantiate(Coins, new Vector3(0, 0.8f, planPosition.position.z + 4f), planPosition.rotation);
                Instantiate(Coins, new Vector3(0, 0.8f, planPosition.position.z + 6f), planPosition.rotation);
            }
            if (randNum==4 || randNum==5||randNum==6)
            {
                Instantiate(Coins, new Vector3(1, 0.8f, planPosition.position.z + -6f), planPosition.rotation);
                Instantiate(Coins, new Vector3(1, 0.8f, planPosition.position.z + -4f), planPosition.rotation);
                Instantiate(Coins, new Vector3(1, 0.8f, planPosition.position.z + -2f), planPosition.rotation);
                Instantiate(Coins, new Vector3(1, 0.8f, planPosition.position.z + 0f), planPosition.rotation);
                Instantiate(Coins, new Vector3(1, 0.8f, planPosition.position.z + 2f), planPosition.rotation);
                Instantiate(Coins, new Vector3(1, 0.8f, planPosition.position.z + 4f), planPosition.rotation);
                Instantiate(Coins, new Vector3(1, 0.8f, planPosition.position.z + 6f), planPosition.rotation);
            }
            if (randNum == 6|| randNum==3)
            {
                Instantiate(Coins, new Vector3(0, 0.8f, planPosition.position.z + -6f), planPosition.rotation);
                Instantiate(Coins, new Vector3(0, 0.8f, planPosition.position.z + -4f), planPosition.rotation);
                Instantiate(Coins, new Vector3(0, 0.8f, planPosition.position.z + -2f), planPosition.rotation);
                Instantiate(Coins, new Vector3(0, 0.8f, planPosition.position.z + 0f), planPosition.rotation);
                Instantiate(Coins, new Vector3(0, 0.8f, planPosition.position.z + 2f), planPosition.rotation);
                Instantiate(Coins, new Vector3(0, 0.8f, planPosition.position.z + 4f), planPosition.rotation);
                Instantiate(Coins, new Vector3(0, 0.8f, planPosition.position.z + 6f), planPosition.rotation);
                Instantiate(Coins, new Vector3(1, 0.8f, planPosition.position.z + -6f), planPosition.rotation);
                Instantiate(Coins, new Vector3(1, 0.8f, planPosition.position.z + -4f), planPosition.rotation);
                Instantiate(Coins, new Vector3(1, 0.8f, planPosition.position.z + -2f), planPosition.rotation);
                Instantiate(Coins, new Vector3(1, 0.8f, planPosition.position.z + 0f), planPosition.rotation);
                Instantiate(Coins, new Vector3(1, 0.8f, planPosition.position.z + 2f), planPosition.rotation);
                Instantiate(Coins, new Vector3(1, 0.8f, planPosition.position.z + 4f), planPosition.rotation);
                Instantiate(Coins, new Vector3(1, 0.8f, planPosition.position.z + 6f), planPosition.rotation);
                Instantiate(Coins, new Vector3(-1, 0.8f, planPosition.position.z + -6f), planPosition.rotation);
                Instantiate(Coins, new Vector3(-1, 0.8f, planPosition.position.z + -4f), planPosition.rotation);
                Instantiate(Coins, new Vector3(-1, 0.8f, planPosition.position.z + -2f), planPosition.rotation);
                Instantiate(Coins, new Vector3(-1, 0.8f, planPosition.position.z + 0f), planPosition.rotation);
                Instantiate(Coins, new Vector3(-1, 0.8f, planPosition.position.z + 2f), planPosition.rotation);
                Instantiate(Coins, new Vector3(-1, 0.8f, planPosition.position.z + 4f), planPosition.rotation);
                Instantiate(Coins, new Vector3(-1, 0.8f, planPosition.position.z + 6f), planPosition.rotation);
            }
            if (randNum<3)
            {
                Instantiate(Coins, new Vector3(-1, 0.8f, planPosition.position.z + -6f), planPosition.rotation);
                Instantiate(Coins, new Vector3(-1, 0.8f, planPosition.position.z + -4f), planPosition.rotation);
                Instantiate(Coins, new Vector3(-1, 0.8f, planPosition.position.z + -2f), planPosition.rotation);
                Instantiate(Coins, new Vector3(-1, 0.8f, planPosition.position.z + 0f), planPosition.rotation);
                Instantiate(Coins, new Vector3(-1, 0.8f, planPosition.position.z + 2f), planPosition.rotation);
                Instantiate(Coins, new Vector3(-1, 0.8f, planPosition.position.z + 4f), planPosition.rotation);
                Instantiate(Coins, new Vector3(-1, 0.8f, planPosition.position.z + 6f), planPosition.rotation);
            }

        }
    }
}
