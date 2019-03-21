using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerMoveScript2 : MonoBehaviour
{
    Animator Action1;
    public int ScoreSpeed;
    public Text scoreS;
    public Vector3 jump;
    public float jumpForce = 2.0f;
    public float speed = 0.1f;
    public float moveSpeed;
    public bool isGrounded;
    Rigidbody rb;
    int currentLocation = 1;
    bool canMove;
    float[] xLocations = { -1f, 0, 1f };
    public AudioClip clip;

    // Start is called before the first frame update
    void Start()
    {
        Action1 = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 3.0f, 0.0f);
    }

    void OnCollisionStay()
    {
        isGrounded = true;
    }

    void FixedUpdate()
    {
        GameManager.score += 1;
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Action1.SetTrigger("Action");
        }
        scoreS.text = "score: " + ScoreSpeed;
        ScoreSpeed += 1;
        if (ScoreSpeed >1000 && ScoreSpeed<5000)
        {
            moveSpeed = .13f;
        }
        if (ScoreSpeed > 5000 && ScoreSpeed < 9000)
        {
            moveSpeed = 0.15f;
        }
        if (ScoreSpeed > 9000)
        {
            moveSpeed = 0.2f;
        }
        float moveHorizontal = Input.GetAxis("Horizontal");

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (currentLocation < 2)
                currentLocation++;
            transform.position = new Vector3(xLocations[currentLocation], transform.position.y, transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (currentLocation > 0)
                currentLocation--;
            transform.position = new Vector3(xLocations[currentLocation], transform.position.y, transform.position.z);
        }

            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + moveSpeed);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {

            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
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
           
            GameManager.coin += 1;
            Destroy(other.gameObject);
            AudioSource.PlayClipAtPoint(clip, transform.position);
        }
    }
}
