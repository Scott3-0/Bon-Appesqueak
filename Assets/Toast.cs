using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Toast : MonoBehaviour
{
    bool Toasting = false;
    bool Toasted = false;
    bool hasToast = false;
    bool hasKnife = true;
    float timeLeft = 5.0f;
    double timerTime;
    int breadPopUp = 0;
    int cut = 0;

    Color untoasted = new Color((156f/255f), (139f / 255f), (76f / 255f), 1f);
    Color toasted = new Color(0.4618f, 0.3833f, 0.2304f, 1);

    public Text timerText;
    public GameObject Timer;
    public Transform Bread;
    public Material ToastShader;

    // Start is called before the first frame update
    void Start()
    {
        ToastShader.SetColor("_Color", untoasted);

        Timer.SetActive(false);
        timeLeft = 5.0f;
        timerTime = 5.0f;
        breadPopUp = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && hasToast == false && hasKnife == true)
        {
            cut++;
            if(cut>=5)
            {
                cutBread();
            }
        }
        else if (Input.GetKeyDown(KeyCode.Space) && Toasted == false && Toasting == false && hasToast == true)
        {
            Toasting = true;
            Timer.SetActive(true);
            Toasting = true;
        }

        if(Toasting == true)
        {
            timeLeft -= Time.deltaTime;
            timerTime = Math.Round(timeLeft, 1); 
            timerText.text = timerTime.ToString("0.0");

            Color breadColor = Color.Lerp(untoasted, toasted, (1f-timeLeft/5f));
            ToastShader.SetColor("_Color", breadColor);

            if (timerTime < 0.1)
            {
                Toasted = true;
                Toasting = false;
                Timer.SetActive(false);
            }
        }

        if(Toasted == true && breadPopUp < 7)
        {
            Bread.Translate(Vector3.up * 7f * Time.deltaTime);
            breadPopUp++;
        }
    }

    void cutBread()
    {
        Bread.Translate(Vector3.right * 30f * Time.deltaTime);
        hasToast = true;
    }
}
