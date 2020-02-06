using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    float speed = 8;
    float rotSpeed = 150;

    void Start()
    {
        
    }
    void Update()
    {
        Vector3 pos = transform.position;

        float mov = Input.GetAxis("Vertical");

        Debug.Log(f);
        gameObject. transform.Translate(Vector3.forward * mov * Time.deltaTime * speed);
        gameObject.transform.Rotate(0, Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime, 0);
    }
}
