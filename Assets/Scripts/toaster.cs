using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toaster : MonoBehaviour
{
    public GameObject toasterToastObj;
    public GameObject toasterToast;
    public GameObject ratBread;

    bool nearToaster = false;
    bool hasBread = false;
    bool toastInToaster = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && nearToaster && hasBread && !toastInToaster)
        {
            toasterToastObj.SetActive(true);
            toastInToaster = true;
            ratBread.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.Space) && nearToaster && hasBread && toastInToaster)
        {
            toasterToast.GetComponent<Toast>().toastIt();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("toaster");
        nearToaster= true;
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("no toaster");
        nearToaster = false;
    }

    public void BreadAcquired()
    {
        hasBread = true;
    }
}
