using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewOrderSlip : MonoBehaviour
{
    public GameObject OrderViewer;
    bool isActive;

    // Start is called before the first frame update
    void Start()
    {
        OrderViewer.SetActive(false);
        isActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O) && isActive == false)
        {
            OrderViewer.SetActive(true);
            isActive = true;
        }

        else if (Input.GetKeyDown(KeyCode.O) && isActive == true)
        {
            OrderViewer.SetActive(false);
            isActive = false;
        }
    }
}
