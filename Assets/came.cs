using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class came : MonoBehaviour
{
    public Transform Player;
    public Vector3 Offset;
    public float Speed;
    
    void Start()
    {
        {
            //GameManager.PlayerRespawned += GetPlayer;
        }

        void GetPlayer(Transform newPlayer)
        {
            Player = newPlayer;
        }
    }

    
    void FixedUpdate()
    {
        {
            Vector3 target = Player.position + Player.TransformDirection(Offset);

            Vector3 TargetVector = target - transform.position;

            transform.LookAt(Player.position + Player.forward);

            transform.position += TargetVector.normalized * Speed * Time.deltaTime * Mathf.Min(3, TargetVector.magnitude);
        }
    }
}
