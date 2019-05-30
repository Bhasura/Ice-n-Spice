using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon;
using Photon.Pun;

public class Shoot : MonoBehaviour
{
    public Rigidbody bulletPrefab;
    public Rigidbody icecreamBullet;
    public Transform GunEnd;
    public int BulletForce = 2000;
    public Transform gun;
    public static Vector3 temp;
    public float force = 200f;
    public static Quaternion rotate;

  
    public void FireGun()
    {
        Rigidbody bulletInstance;
        GunEnd.position = new Vector3();
      
        print(GunEnd.position);
        bulletInstance = Instantiate(bulletPrefab, GunEnd.position, GunEnd.rotation) as Rigidbody;
        bulletInstance.AddForce(GunEnd.forward * force);
        
    }

    
}
