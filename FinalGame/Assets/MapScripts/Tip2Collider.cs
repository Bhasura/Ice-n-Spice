using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tip2Collider : MonoBehaviour
{
    public GameObject tip1;
    public Text text;
    public bool Triggered = false;



    private void OnTriggerEnter(Collider other)
    {
        if(Triggered == false && other.tag == "Player")
        {
            tip1.SetActive(true);
            Time.timeScale = 0f;
            text.text = "Tip 2 : tilt the phone to steer and avoid obstacles";
            Triggered = true;
        }
        
    }
}
