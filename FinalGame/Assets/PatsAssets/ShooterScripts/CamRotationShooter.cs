using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* This is the RotateCam script. This script controls
 * the movement of the camera, which uses the accelerometer
 * of the touch device (smartphone). 
 * 
 * @author Patricia Salcedo 16940187
 * */
public class CamRotationShooter : MonoBehaviour
{
    public float speedX = 2.0f;
    private float xAxis = 0.0f;
    public float accel_x;
    public static Vector3 j;

    private void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
        accel_x = Input.acceleration.x;
    }

    void Update()
    {
        CameraRotate();
        accel_x = Input.acceleration.x * 60;
        transform.RotateAround(transform.position, transform.up, accel_x );
    
    }

    public void CameraRotate()
    {
        xAxis += speedX * Input.acceleration.x;
       // xAxis += speedX * Input.GetAxis("Mouse X");

       // transform.eulerAngles = new Vector3(0, xAxis, 0.0f);
    }



    /*public Vector2 rotAngle;
    Vector3 angle;
    Vector3 tempAngle;
    
    void Update()
    {
        angle.x = (Input.acceleration.y * rotAngle.y);
        angle.y = (Input.acceleration.x * rotAngle.x);

        tempAngle = Vector3.Slerp(tempAngle, angle, Time.deltaTime * 5);

        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(tempAngle), Time.deltaTime * 10);
    }*/
}




    /*float xVal;
    float xValMinMax = 10.0f; // how far the you can pan the camera
    float camSpeed = 20.0f;
    Vector3 acceloSmoothValue;

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
        // acceloSmoothValue = lowPass();
        // xVal += acceloSmoothValue.x;

        // rotation is done around the y-axis
        transform.
    }

    // this method helps smooth out the panning of the camera
    private Vector3 lowPass()
    {
        LowPassFilterFactor = acceloUpdateInterval / LowPassKernelWidthInSeconds;
        lowPassValue = Vector3.Lerp(lowPassValue, Input.acceleration, LowPassFilterFactor);
        return lowPassValue;
    }*/

