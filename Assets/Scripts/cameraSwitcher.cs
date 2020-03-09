using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraSwitcher : MonoBehaviour
{
    public Camera overHead;
    public Camera firstPerson;

    // Start is called before the first frame update
    void Start()
    {
        overHead.enabled = true;
        firstPerson.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Y))
        {
            if (overHead.enabled == true)
            {
                overHead.enabled = false;
                firstPerson.enabled = true;
            }
            else 
            {
                firstPerson.enabled = false;
                overHead.enabled = true;
            }
        }
    }
}
