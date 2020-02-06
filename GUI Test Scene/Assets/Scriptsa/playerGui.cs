using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerGui : MonoBehaviour
{
    //Use This tutorial:
    //https://www.youtube.com/watch?v=iyaSvEQqsPk

    private bool invWinToggle = false;

    void Start()
    {
        
    }
    void Update()
    {

        if (Input.GetKeyDown("e"))
        {
            invWinToggle = !invWinToggle;
        }
        Debug.Log(invWinToggle);
    }
  /*  private void OnGUI()
    {
        bool onoff = false;

        if (Input.GetKey("e"))
        {
            onoff = !onoff;

            if (onoff)
            {
                invWinToggle = true;
            }
            else
            {
                invWinToggle = false;
            }
        }
        Debug.Log(invWinToggle);
    } */
}
