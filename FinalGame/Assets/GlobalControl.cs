using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalControl : MonoBehaviour
{
    public static GlobalControl Instance;

    public int[] complete = new int[] { 0, 0 };
    //first 2 numbers are equip, second 2 numbers are which car you own
    public int[] shopInventory = new int[] { 1, 0 , 0, 0};
  
    public int gold = 1000;

    public bool needUpdate = false;

    void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }
}
