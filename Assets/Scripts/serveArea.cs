using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class serveArea : MonoBehaviour
{
    bool nearServe = false;
    public GameObject ratPlate;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && ratObjects.hasPlate && nearServe)
        {
            ServeFood();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("serve area");
        nearServe = true;
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("no serve area");
        nearServe = false;
    }

    void ServeFood()
    {
        ratObjects.hasPlate = false;
        ratObjects.hasToast = false;
        Debug.Log("serve");
    }
}
