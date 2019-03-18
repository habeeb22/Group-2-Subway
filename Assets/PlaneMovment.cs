using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneMovment : MonoBehaviour
{
    public GameObject plane;
    public Transform planPosition;
    
    public float time=5;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        if (time < 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Instantiate(plane, planPosition.position, transform.rotation);

        }
    }
}
