﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerHp : MonoBehaviour
{
    public static int health = 100;
    
    public static int tempGold = 0;
    GameObject gText;
    public void Start()
    {
        gText = GameObject.Find("GoldTextMesh");
        print(gText.name);
        gText.GetComponent<TextMeshProUGUI>().SetText(tempGold + " Gold");
       
    }
    public void Update()
    {
        gText.GetComponent<TextMeshProUGUI>().SetText(tempGold + " Gold");
    }
}
