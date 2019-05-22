using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData 
{
    public int []stagesComplete;

    public PlayerData(Player player)
    {
       stagesComplete = player.stageCompletion;
    }
}
