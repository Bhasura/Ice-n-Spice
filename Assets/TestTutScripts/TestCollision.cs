using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestCollision : MonoBehaviour
{
    public GameObject other;
    public GameObject endPanel;
    static public int[] complete = new int[] { 0, 0 };
    Player data;
    private void Start()
    {
        endPanel.SetActive(false);
        data = new Player();
        data.LoadPlayer();
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

            print(complete[0]);
        }
        
    }
    

   
}
