using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMovement : MonoBehaviour
{
    public GameObject target;
    // Update is called once per frame
    void Update()
    {
        gameObject.transform.rotation = new Quaternion(90f, 0f, 0f, 0f);
        gameObject.transform.position = target.transform.position + new Vector3(0f, 10f, 0f);
        transform.LookAt(target.transform);
    }
}
