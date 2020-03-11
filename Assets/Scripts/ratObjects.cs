using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ratObjects : MonoBehaviour
{
    public static bool hasPlate = false;
    public static bool hasToast = false;
    public GameObject ratPlate;
    public GameObject ratToast;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hasPlate)
        {
            ratPlate.SetActive(true);
        }
        else
        {
            ratPlate.SetActive(false);
        }

        if (hasToast)
        {
            ratToast.SetActive(true);
        }
        else
        {
            ratToast.SetActive(false);
        }
    }
}
