using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float damage = 20f;
    public float time = 2;

    private void Update()
    {
       //Destroy(gameObject, time);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            EnemyHP enemy = collision.transform.GetComponent<EnemyHP>();
            Destroy(gameObject);
            // invokes the Damage method in EnemyHealth
            print("damage made");
            enemy.Damage(damage);
        }
    }
}
