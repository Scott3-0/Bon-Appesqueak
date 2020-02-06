using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereCast : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit = new RaycastHit();
        float rayDist = 1.5f;

        Debug.DrawRay(transform.position, transform.forward, Color.green);
        if (Physics.Raycast(ray, out hit, rayDist))
        {
            //Debug.Log(hit.transform.name);
            if(hit.transform.name == "Fridge")
            {
               
            }
        }
        else
        {
           // Debug.Log("Nothing hit");
        }
        if (Input.GetKey("e"))
        {
            guiOpen();
        }
    }
    public void guiOpen()
    {

    }
}
