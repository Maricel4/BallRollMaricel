using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    public float speed = 5.0f;
    private float angle = 0.0f;
    // Update is called once per frame
    void Update()
    {
        angle = (angle + speed * Time.deltaTime);
        float angleNew = angle * Mathf.Deg2Rad;
        float zNew = 6.5f * Mathf.Cos(angleNew);
        float xNew = 6.5f * Mathf.Sin(angleNew);
        transform.position = new Vector3(xNew, .5f, zNew);
    }
}
