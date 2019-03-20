using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveScript : MonoBehaviour
{
    public Vector3 jump;
    public float jumpForce = 2.0f;
    public float speed = 10;

    public bool isGrounded;
    Rigidbody rb;
    int limit = 0;
    bool canMove;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 3.0f, 0.0f);
    }

    void OnCollisionStay()
    {
        isGrounded = true;
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");

        if (Input.GetKeyDown(KeyCode.RightArrow))
            transform.position = new Vector3(1.3f, 0, 0);

        if (Input.GetKeyDown(KeyCode.LeftArrow))
            transform.position = new Vector3(-1.3f, 0, 0);

        if (Input.GetKey(KeyCode.UpArrow))
            transform.position = new Vector3(0, 0, transform.position.z + 2f);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {

            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
        //else
            //transform.position = new Vector3(transform.position.x, transform.position.y, 0*Time.deltaTime);

    }
}
