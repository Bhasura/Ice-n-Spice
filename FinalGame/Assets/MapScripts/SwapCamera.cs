using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapCamera : MonoBehaviour
{
    [SerializeField] public GameObject carCamera;
    [SerializeField] public GameObject turretCamera;
    public GameObject shootButton;
    public GameObject accelButton;
    public GameObject shooterButton;
    public GameObject driverButton;
    public static bool carCamActive;

    void Start()
    {
        carCamera.SetActive(true);
        carCamActive = true;
        turretCamera.SetActive(false);

    }



    public void onSwapButtonClickedShooter()
    {


        carCamActive = false;
        Update();


        


    }
    public void onSwapButtonClickedDriver()
    {


        carCamActive = true;
        Update();


        


    }
    void Update()
    {
        if (carCamActive == false)
        {
            carCamera.SetActive(false);
            turretCamera.SetActive(true);
            shootButton.SetActive(true);
            accelButton.SetActive(false);
            shooterButton.SetActive(false);
            driverButton.SetActive(true);
            
        }
        else
        {
            carCamera.SetActive(true);
            turretCamera.SetActive(false);
            shootButton.SetActive(false);
            accelButton.SetActive(true);
            driverButton.SetActive(false);
            shooterButton.SetActive(true);
            

        }
    }
}
