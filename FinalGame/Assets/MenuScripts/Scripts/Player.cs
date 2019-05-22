using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int []stageCompletion;

    public Player ()
    {
        stageCompletion = TestCollision.complete;
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
    }
}
