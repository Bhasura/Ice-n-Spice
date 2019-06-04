using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tip3Collider : MonoBehaviour
{
    public GameObject tip1;
    public Text text;
    public bool triggered = false;



    private void OnTriggerEnter(Collider other)
    {
        if(triggered == false && other.tag == "Player")
        {
            tip1.SetActive(true);
            Time.timeScale = 0f;

            text.text = "Tip 3 : Press the shooter button to swap to shooter and tilt the phone to aim at the enemy and press shoot";
            triggered = true;
        }
        
    }
}
