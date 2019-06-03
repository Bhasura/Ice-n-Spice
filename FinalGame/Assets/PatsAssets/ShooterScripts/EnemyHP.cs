using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* This is the EnemyHP script. This script sets the
 * enemy's health system that is affected by the shooter
 * (when object is constructed in the ShooterController script).
 * 
 * @author Patricia Salcedo 16940187
 * */
public class EnemyHP : MonoBehaviour
{
    // The box's current health point total, which is initialised here as 100 units.
    // but can be changed in Unity's editor 
    public float currentHealth = 100f;

    /// <summary>
    /// Sets the enemy's health system that is affected by the shooter
    /// 
    /// </summary>
    public void Start()
    {
        TextMesh healthInitial = (TextMesh)gameObject.GetComponentInChildren(typeof(TextMesh));
        healthInitial.text = currentHealth + " Health";
    }
    public void Damage(float damageAmount)
    {
        // The enemy takes damage and loses health
        currentHealth -= damageAmount;

        TextMesh healthPercent = (TextMesh)gameObject.GetComponentInChildren(typeof(TextMesh));
        healthPercent.text = currentHealth + " Health";

        if (currentHealth <= 0)
        {
            // If health has fallen below zero, enemy is deactivated
            gameObject.SetActive(false);
            PlayerHp.tempGold = PlayerHp.tempGold + 100;
            GlobalControl.Instance.gold += 100;
        }
    }
}
