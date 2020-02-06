using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementScript : MonoBehaviour
{
    public float panSpeed = 20f;
    public float rotSpeed = .01f;

    void Update()
    {
        Vector3 pos = transform.position;

        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        transform.rotation = Quaternion.LookRotation(movement);

        if (Input.GetKey("w"))
        {
            pos.z += panSpeed * Time.deltaTime;
            transform.Translate(movement * rotSpeed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey("s"))
        {
            pos.z -= panSpeed * Time.deltaTime;
            transform.Translate(movement * rotSpeed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey("d"))
        {
            pos.x += panSpeed * Time.deltaTime;
            transform.Translate(movement * rotSpeed * Time.deltaTime, Space.World);
        } 
        if (Input.GetKey("a"))
        {
            pos.x -= panSpeed * Time.deltaTime;
            transform.Translate(movement * rotSpeed * Time.deltaTime, Space.World);
        }

        transform.position = pos;
    }
}
