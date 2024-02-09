using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawRay : MonoBehaviour
{

    void Update()
    {
        Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
        Debug.DrawRay(transform.position, forward, Color.red);
    }
}