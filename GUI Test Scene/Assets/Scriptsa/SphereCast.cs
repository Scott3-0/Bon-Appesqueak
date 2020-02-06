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
        RaycastHit hit;
        Ray ray;
        if ( 
            Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit))
        {
        }
        Debug.DrawRay(transform.position, transform.forward, Color.green);
    }
}
