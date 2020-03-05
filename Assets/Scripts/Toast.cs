using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Toast : MonoBehaviour
{
    bool Toasting = false;
    bool Toasted = false;
    bool hasBread = false;
    bool hasKnife = true;
    bool breadCut = false;
    bool nearBread = false;
    float timeLeft = 5.0f;
    double timerTime;
    int breadPopUp = 0;
    int cut = 0;

    Color untoasted = new Color((156f/255f), (139f / 255f), (76f / 255f), 1f);
    Color toasted = new Color(0.4618f, 0.3833f, 0.2304f, 1);

    public Text timerText;
    public GameObject Timer;
    public GameObject Loaf;
    public Transform BreadTransform;
    public GameObject Bread;
    public Material ToastShader;
    public GameObject RatBread;

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
        if (Input.GetKeyDown(KeyCode.Space) && !hasBread && breadCut && nearBread)
        {
            hasBread = true;
            getBread();
        }

        if (Input.GetKeyDown(KeyCode.Space) && !Toasted && !Toasting && hasBread)
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
            BreadTransform.Translate(Vector3.up * 7f * Time.deltaTime);
            breadPopUp++;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("bread");
        nearBread = true;
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("no bread");
        nearBread = false;
    }

    public void BreadAcquired()
    {
        breadCut = true;
    }

    void getBread()
    {
        Bread.GetComponent<Renderer>().enabled = false;
        RatBread.SetActive(true);
    }
}
