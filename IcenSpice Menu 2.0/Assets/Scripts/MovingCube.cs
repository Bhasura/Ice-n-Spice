using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCube : MonoBehaviour
{
    public float forwardSpeed;
    public float sidewaysSpeed;
    public float amplitude;

    private Vector3 tempPosition;

    void Start()
    {
        tempPosition = transform.position;
    }

    void FixedUpdate()
    {
        tempPosition.z -= forwardSpeed; // if hSpeed is positive, it moves to the right, if negative, moves to the left
        tempPosition.x = Mathf.Sin(Time.realtimeSinceStartup * sidewaysSpeed) * amplitude; // creates up and down movement
        transform.position = tempPosition;
    }
}
