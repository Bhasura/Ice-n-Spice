using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;

public class End_Collider : MonoBehaviour
{
    public GameObject truck;
    public GameObject endPanel;
   
    
    public int gold = 0;

    public void saveToGlobal()
    {
        GlobalControl.Instance.gold = GlobalControl.Instance.gold + gold;
        GlobalControl.Instance.needUpdate = true;
        print(GlobalControl.Instance.gold);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //For stage 1 or tutorial stage

        if (other.tag == "Player")
        {
            endPanel.SetActive(true);
            gold = 10000;
            saveToGlobal();
        }
      

    }


}
