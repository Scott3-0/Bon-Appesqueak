using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ToastTimer : MonoBehaviour
{
    double timeLeft = 5.0f;
    double timerTime;

    public Text timerText;

    // Start is called before the first frame update
    void Start()
    {
        timeLeft = 5.0f;
        timerTime = 5.0f;
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        timerTime = Math.Round(timeLeft, 2);
        timerText.text = timerTime.ToString();
        if (timeLeft<=0)
        {

        }
    }
}
