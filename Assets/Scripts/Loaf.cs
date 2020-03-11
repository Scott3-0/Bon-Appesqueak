using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loaf : MonoBehaviour
{
    public Transform Bread;
    public Transform LoafTransform;
    public GameObject breadPrefab;
    public GameObject Toaster;
    public GameObject RatBread;

    GameObject breadSlice;

    bool breadCut = false;
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
            if (Input.GetKeyDown(KeyCode.Space) && !breadCut) //and hasToast==false and hasKnife==true
            {
                cut++;
                if (cut >= 5 && !breadCut)
                {
                    cutBread();
                }
            }
            else if (Input.GetKeyDown(KeyCode.Space) && breadCut)
            {
                Destroy(breadSlice);
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
        breadSlice = Instantiate(breadPrefab, new Vector3(40.745f, 1.3f, 13.09f), Quaternion.identity);
        breadSlice.transform.Translate(Vector3.right * -30f * Time.deltaTime);
        breadCut = true;
        Toaster.GetComponent<toaster>().BreadAcquired();
        RatBread.SetActive(true);
    }
}