using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    float time = 60;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 4, 0);
        time -= Time.deltaTime;
        if (time < 0)
        {
            Destroy(gameObject);
        }
    }
}
