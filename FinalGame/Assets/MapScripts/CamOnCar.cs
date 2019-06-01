using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamOnCar : MonoBehaviour
{
    [SerializeField] public Camera car;
    [SerializeField] public Camera turret;
    void Update()
    {
        if (InstantiateSolo.carCamActive == true)
        {
            car.GetComponent<Camera>().enabled = true;
            turret.GetComponent<Camera>().enabled = false;
        }
        else
        {
            car.GetComponent<Camera>().enabled = false;
            turret.GetComponent<Camera>().enabled = true;
        }
    }
}
