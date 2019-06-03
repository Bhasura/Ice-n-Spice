using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateSolo : MonoBehaviour
{
    public static bool carCamActive;
    public static GameObject truckDef;
    public static GameObject child;
    public Transform spawnPoint;

    //buttons
    public GameObject shootButton;
    public GameObject accelButton;
    public GameObject shooterButton;
    public GameObject driverButton;

    // Start is called before the first frame update
    void Start()
    {
        if(GlobalControl.Instance.shopInventory[0] == 1)
        {
            truckDef = (GameObject)(Resources.Load("SoloTrucksRESOURCE/IceTruck_Solo"));
            truckDef = Instantiate(truckDef, spawnPoint.position, spawnPoint.rotation);

            carCamActive = true;
        }
        if (GlobalControl.Instance.shopInventory[1] == 1)
        {
            truckDef = (GameObject)(Resources.Load("SoloTrucksRESOURCE/WhiteTruck_Solo"));
            truckDef = Instantiate(truckDef, spawnPoint.position, spawnPoint.rotation);

            carCamActive = true;
        }
       
        
        
    }

    // Update is called once per frame
    void Update()
    {
        child = truckDef.transform.Find("Turret").gameObject;
 
        if (carCamActive == false)
        {
            shootButton.SetActive(true);
            accelButton.SetActive(false);
            shooterButton.SetActive(false);
            driverButton.SetActive(true);

        }
        else
        {
            shootButton.SetActive(false);
            accelButton.SetActive(true);
            driverButton.SetActive(false);
            shooterButton.SetActive(true);


        }
    }

    public void shooterButtonClicked()
    {
        carCamActive = false;
        Update();
    }

    public void driverButtonClicked()
    {
        carCamActive = true;
        Update();
    }

}
