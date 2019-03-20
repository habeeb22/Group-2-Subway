using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;

    float distance;
    Vector3 playerPrevPos, playerMoveDir;

    // Use this for initialization
    void Start()
    {
        offset = transform.position - player.transform.position;

        distance = offset.magnitude;
        playerPrevPos = player.transform.position;
    }

    void FixedUpdate()
    {

        playerMoveDir = player.transform.position - playerPrevPos;
        // playerMoveDir.normalized();
        transform.position = player.transform.position - playerMoveDir * distance;

        transform.LookAt(player.transform.position);

        playerPrevPos = player.transform.position;
    }
}
