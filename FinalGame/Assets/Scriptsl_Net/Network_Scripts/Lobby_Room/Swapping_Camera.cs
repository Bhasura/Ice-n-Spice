using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.EventSystems;

public class Swapping_Camera : MonoBehaviour
{

    [SerializeField] public GameObject carCamera;
    [SerializeField] public GameObject turretCamera;
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


        print("you have swaped to shooter");


    }
    public void onSwapButtonClickedDriver()
    {


        carCamActive = true;
        Update();


        print("you have swapped to driver");


    }
    void Update()
    {
        if (carCamActive==false)
        {
            carCamera.SetActive(false);
            turretCamera.SetActive(true);
            print("you have swapped to turret view");
        }
        else
        {
            carCamera.SetActive(true);
            turretCamera.SetActive(false);
            print("you have swapped to driver view.");

        }
    }

}
