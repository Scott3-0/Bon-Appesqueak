using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OrderSlips : MonoBehaviour
{
    public Text orderText;

    List<string> orders = new List<string>();
    int orderNumber = 0;
    // Start is called before the first frame update
    void Start()
    {
        orders.Add("Order 1: Toast");
        orders.Add("Order 2: Toast");
        orders.Add("Order 3: Toast w/ Butter");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            if ((orderNumber+1) < orders.Count)
            {
                orderNumber++;
            }
            else
            {
                orderNumber = 0;
            }
            orderText.text = orders[orderNumber];
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            if (orderNumber > 0)
            {
                orderNumber--;
            }
            else
            {
                orderNumber = (orders.Count -1);
            }
            orderText.text = orders[orderNumber];
        }
    }
}
