using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageUnlocked : MonoBehaviour
{

    public bool unlocked(bool s2unlocked, int s1Completion)
    {
        bool Stage2Unlocked = false;
        if (s1Completion == 100)
        {
            Stage2Unlocked = true;
        }
        return Stage2Unlocked;
    }
}
