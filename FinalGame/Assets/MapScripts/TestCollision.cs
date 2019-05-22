using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestCollision : MonoBehaviour
{
    public GameObject other;
    public GameObject endPanel;
    public GameObject settingsPanel;
    static public int[] complete = new int[] { 0, 0 };
    Player data;
    private void Start()
    {
        
        data = new Player();
       // data.LoadPlayer();
        print(complete[0]);
        
        
    }
    private void OnTriggerEnter(Collider other)
    {
        //For stage 1 or tutorial stage
        if(SceneManager.GetActiveScene().name == "TestSceneForMenu")
        {
            endPanel.SetActive(true);
            complete[0] = 100;
           
            print(complete[0]);
            data.SavePlayerData();

           
        }
        else if (SceneManager.GetActiveScene().name == "Stage2")
        {
            endPanel.SetActive(true);
            complete[1] = 100;

            print(complete[1]);
            data.SavePlayerData();

            print(complete[1]);
        }
    }
    

   
}
