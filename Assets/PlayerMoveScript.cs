using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveScript : MonoBehaviour
{
    public KeyCode moveL;
    public KeyCode moveR;
    public float horizVel = 0;
    public int lamNum = 2;
    public string controlLocked = "n";
    public GameObject plane;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        GetComponent<Rigidbody>().velocity = new Vector3(horizVel, 0, 4);
//<<<<<<< HEAD
//<<<<<<< HEAD
//=======

//>>>>>>> 5f2a7f791a59aa8def60e5b72d6045b49c460fd0
//=======

//>>>>>>> 5f2a7f791a59aa8def60e5b72d6045b49c460fd0
        if ((Input.GetKeyDown(KeyCode.LeftArrow)) && (lamNum>1) && (controlLocked == "n"))
        {
            horizVel = -2;
            StartCoroutine(stopSlide());
            lamNum -= 1;
            controlLocked = "y";
        }
        if ((Input.GetKeyDown(KeyCode.RightArrow)) && (lamNum < 3) && (controlLocked == "n"))
        {
            horizVel = 2;
            StartCoroutine(stopSlide());
            lamNum += 1;
            controlLocked = "y";
        }

    }
    IEnumerator stopSlide()
    {
        yield return new WaitForSeconds(.5f);
        horizVel = 0;
        controlLocked = "n";
//<<<<<<< HEAD
//<<<<<<< HEAD
//=======
//=======
//>>>>>>> 5f2a7f791a59aa8def60e5b72d6045b49c460fd0
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Lose")
        {
            print("loseeeeee");
        }
//<<<<<<< HEAD
//>>>>>>> 5f2a7f791a59aa8def60e5b72d6045b49c460fd0
//=======
//>>>>>>> 5f2a7f791a59aa8def60e5b72d6045b49c460fd0
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Coin")
        {
            GameManager.coin += 1;
            Destroy(other.gameObject);
        }
    }
}
