using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Random = UnityEngine.Random;

public class MPlayer : MonoBehaviour
{
    Vector3 PlayerPosition;
    public GameObject Wall0;
    public GameObject Wall1;
    public GameObject Wall2;
    float Zx0 = 0;
    float Limits_L =-50;
    float Limits_R = 50;
    List<GameObject> walls = new List<GameObject>();



    void Start()
    {
        //Rigidbody myRB;
       // myRB = GetComponent<Rigidbody>();
        PlayerPosition = transform.position;
        Zx1 = (Math.Abs(transform.position.z));
        Zx2 = transform.position.z + 5;
    }

    // Update is called once per frame
    void Update()
    {
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                transform.Translate(0, 0, 5);
                int Len = walls.Count;

                if (Len > 0)
                {
                    Wall0 = walls[Len-1];
                    Zx0 = Wall0.transform.position.z;
                }
                else Zx0 = transform.position.z;




                if (  transform.position.z > 0)
                {

                    if (transform.position.z  >= Zx0) //Zx1
                    {
                         Zx0 = Zx0 + 30;
                        // PlayerPosition = new Vector3(n1, 0, Zx); //Mathf.Abs
                         Vector3 position = new Vector3(Random.Range(Limits_L, Limits_R), transform.position.y, 
                             Random.Range(Zx0, (Zx0 + 30)));
                         GameObject instance = Instantiate(Wall1, position, transform.rotation) as GameObject;
                         walls.Add(instance);

                        // Instantiate(Wall2, position, transform.rotation);
                        print("Zaher");
                    }
                }
                else
                {
                    // print(Wall1.transform.position.z);
                    if (Zx0 <= transform.position.z)
                    {
                        Zx0 = transform.position.z + 11;
                        Vector3 position = new Vector3(Random.Range(Limits_L, Limits_R), transform.position.y,
                            Random.Range(Zx0, (Zx0 + 20)));
                        GameObject instance = Instantiate(Wall1, position, transform.rotation) as GameObject;
                        walls.Add(instance);
                        // Instantiate(Wall1, position, transform.rotation);
                   
                         print("Waleed");
                    }
                }
            }
            // transform.position += transform.forward * Speed * Time.deltaTime;
            // transform.forward = new Vector3(PlayerPosition.x, 0,5); // (PlayerPosition.z + 0.1f * Time.deltaTime)
            // transform.position= new Vector3 (PlayerPosition.x, PlayerPosition.y, 5);
            //transform.SetPositionAndRotation(new Vector3(PlayerPosition.x, PlayerPosition.y, transform.rotation));

            if (Input.GetKey(KeyCode.DownArrow)) transform.Translate (0, 0, -5);
            if (Input.GetKey(KeyCode.LeftArrow)) transform.Translate (-5, 0, 0);
            if (Input.GetKey(KeyCode.RightArrow)) transform.Translate( 5, 0, 0);
        }
    }
}
