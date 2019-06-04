using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestCollision : MonoBehaviour
{
    public GameObject truck;
    public GameObject endPanel;
    public GameObject settingsPanel;
    public int[] complete = new int[] { 0, 0 };
    public int gold = 0;

    public void saveToGlobal()
    {
        GlobalControl.Instance.complete[0] = complete[0];
        GlobalControl.Instance.complete[1] = complete[1];
        GlobalControl.Instance.gold = GlobalControl.Instance.gold + gold;
        GlobalControl.Instance.needUpdate = true;
        print(GlobalControl.Instance.gold);
        print("Global 0: " + GlobalControl.Instance.complete[0]);
        print("Global 1: " + GlobalControl.Instance.complete[1]);
    }

    private void OnTriggerEnter(Collider other)
    {
        //For stage 1 or tutorial stage

        if (SceneManager.GetActiveScene().name == "TestSceneForMenu" && other.tag == "Player")
        {
            endPanel.SetActive(true);
            complete[0] = 100;
            gold = 10000;
            saveToGlobal();
        }
        else if (SceneManager.GetActiveScene().name == "Stage2" && other.tag == "Player")
        {
            endPanel.SetActive(true);
            complete[0] = 100;
            complete[1] = 100;
            gold = 10000;
            saveToGlobal();
        }
        
    }
    

   
}
