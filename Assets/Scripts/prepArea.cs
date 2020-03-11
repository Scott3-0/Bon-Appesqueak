using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prepArea : MonoBehaviour
{
    bool nearPrep = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !ratObjects.hasPlate && nearPrep)
        {
            ratObjects.hasPlate = true;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("prep");
        nearPrep = true;
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("no prep");
        nearPrep = false;
    }
}
