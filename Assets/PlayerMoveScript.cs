using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveScript : MonoBehaviour
{
    public KeyCode moveL;
    public KeyCode moveR;
    public float horizVel;
    public GameObject plane;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 4);
        if (Input.GetKeyDown(moveL))
        {
            horizVel = -2;
            StartCoroutine(stopSlide());

        }
        if (Input.GetKeyDown(moveR))
        {
            horizVel = 2;
            StartCoroutine(stopSlide());
        }

    }
    IEnumerator stopSlide()
    {
        yield return new WaitForSeconds(.5f);
        horizVel = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Coin")
        {
            GameManager.coin += 1;
            Destroy(other.gameObject);
        }
    }
}
