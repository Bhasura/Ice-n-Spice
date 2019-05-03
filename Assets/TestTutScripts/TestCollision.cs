using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestCollision : MonoBehaviour
{
    public GameObject other;
    static public int[] complete = new int[] { 0, 0 };
    Player data;
    private void Start()
    {
        data = new Player();
        data.LoadPlayer();
        print(complete[0]);
        
        
    }
    private void OnTriggerEnter(Collider other)
    {
        //For stage 1 or tutorial stage
        if(SceneManager.GetActiveScene().name == "TestSceneForMenu")
        {
            complete[0] = 100;
            
            print(complete[0]);
            data.SavePlayerData();
            
            SceneManager.LoadScene(0);

            print(complete[0]);
        }
        
    }
    

   
}
