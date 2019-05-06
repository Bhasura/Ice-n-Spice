using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tip1Collider : MonoBehaviour
{
    public GameObject tip1;
    public Text text;
    public bool triggered = false;



    private void OnTriggerEnter(Collider other)
    {
        if (triggered == false)
        {
            tip1.SetActive(true);
            Time.timeScale = 0f;
            text.text = "Tip 1 : Tap the accelerator to move and the break to stop";
            triggered = true;
        }
           
    }
}
