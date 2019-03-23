using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamDay12 : MonoBehaviour
{
    public Transform Player;
    public Vector3 Offset;
    public float speed;
    public float forwards;
    // Start is called before the first frame update
    void Start()
    {
       Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }
    void GetPlayer(Transform newPlayer)
    {
        Player =  newPlayer;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (Player != null)
        {
            //Vector3 target = Player.position + Player.forward * Offset.z + Player.up * Offset.y;
            Vector3 target = Player.position + Player.TransformDirection(Offset);
            Vector3 TargetVector = target - transform.position;
            transform.LookAt(Player.position + Player.forward * forwards);
            transform.position += TargetVector.normalized * speed * Time.deltaTime * Mathf.Min(1, TargetVector.magnitude);

        }
    }
}
