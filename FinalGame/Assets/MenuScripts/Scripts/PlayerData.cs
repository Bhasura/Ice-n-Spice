using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData 
{
    public int []stagesComplete;
    public int[] inventory;
    public int gold;

    public PlayerData(Player player)
    {
        stagesComplete = player.stageCompletion;
        inventory = player.inventory;
        gold = player.gold;
        
    }
}
