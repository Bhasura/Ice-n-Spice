using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData 
{
    public int []stagesComplete;
    public int gold;
    public int playerPrefab;

    public PlayerData(Player player)
    {
        stagesComplete = player.stageCompletion;
        gold = player.gold;
        playerPrefab = player.playerPrefab;
    }
}
