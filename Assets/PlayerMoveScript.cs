using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveScript : MonoBehaviour
{
    public float horizVel = 0;
    public int lamNum = 2;
    public string controlLocked = "n";
    public GameObject plane;
    Rigidbody RB;
    public float jumpspeed = 5;
    bool onground = true;
    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {


        RB.velocity = new Vector3(horizVel, 0, 4);

        if (Input.GetKeyDown(KeyCode.Space) && onground)
        {
            RB.AddForce(Vector3.up * jumpspeed, ForceMode.Impulse);
            onground = false;
        }
        else if ((Input.GetKeyDown(KeyCode.LeftArrow)) && (lamNum > 1) && (controlLocked == "n"))
        {
            horizVel = -2;
            StartCoroutine(stopSlide());
            lamNum -= 1;
            controlLocked = "y";
        }
        else if ((Input.GetKeyDown(KeyCode.RightArrow)) && (lamNum < 3) && (controlLocked == "n"))
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
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Coin")
        {
            //GameManager.coin += 1;
            Destroy(other.gameObject);
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Ground")
            onground = true;
    }
}
