using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    public float accel_x;
    // Use this for initialization
    void Start()
    {
        accel_x = Input.acceleration.x;
    }

    void Update()
    {
        accel_x = Input.acceleration.x * 60;
        transform.RotateAround(transform.position, transform.up, accel_x * Time.deltaTime);
    }


}

