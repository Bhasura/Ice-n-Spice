using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCam : MonoBehaviour
{
    float xVal;
    float xValMinMax = 10.0f; // how far the you can pan the camera
    float camSpeed = 20.0f;
    Vector3 acceloSmoothValue; // for making the camera panning smooth

    public float acceloUpdateInterval = 1.0f / 100.0f;
    public float LowPassKernelWidthInSeconds = 0.001f;
    public Vector3 lowPassValue = Vector3.zero;
    private float LowPassFilterFactor;

    void Start()
    {
        // Get local rotation
        Vector3 localR = transform.localRotation.eulerAngles;
        float rotationx = localR.x;
        float rotationy = localR.y;
    }
    
    void Update()
    {
         AccelerometerCameraRotation();
    }

    private void AccelerometerCameraRotation()
    {
        if (xVal < -xValMinMax)
        {
            xVal = -xValMinMax;
        }
        else if (xVal > xValMinMax)
        {
            xVal = xValMinMax;
        }
        acceloSmoothValue = lowPass();
        xVal += acceloSmoothValue.x;
        transform.rotation = new Quaternion(0, xVal, 0, camSpeed);
    }

    private Vector3 lowPass()
    {
        LowPassFilterFactor = acceloUpdateInterval / LowPassKernelWidthInSeconds;
        lowPassValue = Vector3.Lerp(lowPassValue, Input.acceleration, LowPassFilterFactor);
        return lowPassValue;
    }
}

