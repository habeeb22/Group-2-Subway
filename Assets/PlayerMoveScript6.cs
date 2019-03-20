using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMoveScript6 : MonoBehaviour
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

        //FindObjectOfType<GameOverx>().EndGame();

    }
    
    IEnumerator stopSlide()
    {
        yield return new WaitForSeconds(.5f);
        horizVel = 0;
        controlLocked = "n";
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Lose")
        {

            SceneManager.LoadScene("GameOver");


        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Coin")
        {
            GameManager1.coin += 1;
            Destroy(other.gameObject);
        }
    }
}
