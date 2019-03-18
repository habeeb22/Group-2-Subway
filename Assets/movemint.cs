using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Animator))]
public class movemint : MonoBehaviour
{
    Rigidbody myRB;
    public float Speed = 5;
    Animator player;
    public float TurnSpeed = 5;
    void Start()
    {
        player = GetComponent<Animator>();
        myRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position =
                new Vector3(transform.position.x,
                transform.position.y,
                transform.position.z + 5 * Time.deltaTime);
                player.SetFloat("speed", 10);
            }
        if (Input.GetKey(KeyCode.DownArrow))
        { 
            transform.position =
                new Vector3(transform.position.x,
                transform.position.y,
                transform.position.z - 5 * Time.deltaTime);
            player.SetFloat("speed", 10);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        { 
            transform.position =
                new Vector3(transform.position.x + 5 * Time.deltaTime,
                transform.position.y,
                transform.position.z);
            player.SetFloat("speed", 10);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        { 
            transform.position =
                new Vector3(transform.position.x - 5 * Time.deltaTime,
                transform.position.y,
                transform.position.z);
            player.SetFloat("speed", 10);
        }
    }
}
