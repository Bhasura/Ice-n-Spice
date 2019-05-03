using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int gold = 100;
    public int []stageCompletion;
    public int playerPrefab = 1;

    public Player ()
    {
        stageCompletion = TestCollision.complete;
    }

    public void SavePlayerData()
    {
        //saves this player data
        print(gold);
        SaveData.SavePlayer(this);
        SaveData.LoadPlayer();
    }

    //put into buttons and game can be loaded. Or upon starting game.
    public void LoadPlayer()
    {
        PlayerData data = SaveData.LoadPlayer();

        gold = data.gold;
        stageCompletion = data.stagesComplete;
        playerPrefab = data.playerPrefab;
    }
}
