using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loaf : MonoBehaviour
{
    public Transform Bread;
    public GameObject breadObject;
    public GameObject Toaster;

    bool hasBread = false;
    bool nearBread = false;

    int breadPopUp = 0;
    int cut = 0;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (nearBread)
        {
            if (Input.GetKeyDown(KeyCode.Space)) //and hasToast==false and hasKnife==true
            {
                cut++;
                if (cut >= 5 && !hasBread)
                {
                    cutBread();
                }
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("loaf");
        nearBread = true;
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("no loaf");
        nearBread = false;
    }

    void cutBread()
    {
        Bread.Translate(Vector3.right * -30f * Time.deltaTime);
        hasBread = true;
        breadObject.GetComponent<Toast>().BreadAcquired();
        Toaster.GetComponent<toaster>().BreadAcquired();
    }
}

//-50.8, 1425.9, 436.3
//0, -180, 270

    //42.349, 1.3, 13.09
    //scale 0.14, 1, 0.9