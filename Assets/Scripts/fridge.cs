﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fridge : MonoBehaviour
{
    public GameObject Rat;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        //Debug.Log("fridge");
        //Rat.GetComponent<Toast>().cuttingBread();
    }
}
