using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveScript2 : MonoBehaviour
{
    public Vector3 jump;
    public float jumpForce = 2.0f;
    public float speed = 10;
    public bool isGrounded;
    Rigidbody rb;
    int currentLocation = 1;
    bool canMove;
    float[] xLocations = { -1.3f, 0, 1.3f };

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

            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 2f);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {

            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }
}
