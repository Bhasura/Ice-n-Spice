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
    // The box's current health point total, which is initialised here as 60 units.
    // but can be changed in Unity's editor 
    public float currentHealth = 100f;

    public GameObject floatingTextPrefab;

    public void Damage(float damageAmount)
    {
        if(floatingTextPrefab && currentHealth > 0)
        {
            ShowFloatingText();
        }

        // subtract gunDamage amount when Damage function is called
        currentHealth -= damageAmount;
        
        if (currentHealth <= 0)
        {
            // if health has fallen below zero, enemy is deactivated
            gameObject.SetActive(false);
        }
    }

    private void ShowFloatingText()
    {
        var go = Instantiate(floatingTextPrefab, transform.position, Quaternion.identity, transform);
        go.GetComponent<TextMesh>().text = currentHealth.ToString();
    }
}
