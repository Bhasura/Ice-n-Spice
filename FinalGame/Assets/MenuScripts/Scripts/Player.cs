using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int []stageCompletion;
    public int[] inventory;
    public int gold;

    public Player ()
    {
      
    }
   
    public void loadFromGlobal()
    {
        stageCompletion = GlobalControl.Instance.complete;
        inventory = GlobalControl.Instance.shopInventory;
        gold = GlobalControl.Instance.gold;
        
        SavePlayerData();
    }
    public void loadToGlobal()
    {
        GlobalControl.Instance.complete = stageCompletion;
        GlobalControl.Instance.shopInventory = inventory;
        GlobalControl.Instance.gold = gold;
        
    }
    public void SavePlayerData()
    {
        //saves this player data
        SaveData.SavePlayer(this);
        SaveData.LoadPlayer();
    }

    //put into buttons and game can be loaded. Or upon starting game.
    public void LoadPlayer()
    {
        PlayerData data = SaveData.LoadPlayer();

        stageCompletion = data.stagesComplete;
        inventory = data.inventory;
        gold = data.gold;
        

    }
}
