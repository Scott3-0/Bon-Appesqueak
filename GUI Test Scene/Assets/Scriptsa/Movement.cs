using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    double speed;

    void Start()
    {
        
    }
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        if (Input.GetAxisRaw("Fire3") > 0)
        {
            speed = 0.13;
        }
        else
        {
            speed = 0.065;
        }
        Debug.Log(speed);
        gameObject.transform.position = new Vector3(transform.position.x + (float)(x * speed),
            0.125f, transform.position.z + (float)(y * speed));
    }
}
