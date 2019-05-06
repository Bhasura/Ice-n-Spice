using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class End_Collider : MonoBehaviour
{

    public GameObject endPanel;


    
    private void OnTriggerEnter(Collider other)
    {
      
            endPanel.SetActive(true);
        Time.timeScale = 0f;

    }



}
