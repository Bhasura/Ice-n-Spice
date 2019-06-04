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
    [SerializeField] public MonoBehaviour turretRotation;
    
    void Start()
    {
        carCamera.SetActive(true);
        carCamActive = true;
        turretCamera.SetActive(false);
        turretRotation.enabled = false;

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
            turretRotation.enabled = true;
            carCamera.SetActive(false);
            turretCamera.SetActive(true);
            shootButton.SetActive(true);
            accelButton.SetActive(true);
            shooterButton.SetActive(true);
            driverButton.SetActive(true);

        }
        else
        {
            turretRotation.enabled = false;
            carCamera.SetActive(true);
            turretCamera.SetActive(false);
            shootButton.SetActive(true);
            accelButton.SetActive(true);
            driverButton.SetActive(true);
            shooterButton.SetActive(true);


        }
    }
}
