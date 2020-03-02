using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 50;
    public float Between;
    float turnspeed = 150f;

    bool canGo = true;

    void Update()
    {
        Vector3 pos = transform.position;
        RaycastHit hit;
        Ray myRay = new Ray(transform.position, transform.forward);
        float distance = 1f;
        //use raycasts here. check max distance, use a bool

        float mov = Input.GetAxis("Vertical");
        if (canGo == true)
        {
            gameObject.transform.Translate(Vector3.forward * mov * Time.deltaTime * speed);
        }

        gameObject.transform.Rotate(0, Input.GetAxis("Horizontal") * turnspeed * Time.deltaTime, 0);

        Debug.DrawRay(transform.position, transform.forward, Color.green);

        if (Physics.Raycast(myRay, out hit, distance))
        {
            canGo = false;
            Debug.Log("Hit");
            Between = hit.distance;
        }
        else
        {
            canGo = true;
        }


    }
}