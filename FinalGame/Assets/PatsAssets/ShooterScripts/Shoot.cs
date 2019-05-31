using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon;
using Photon.Pun;

public class Shoot : MonoBehaviour
{
    //public Transform gunEnd;
    public GameObject bullet;
    public float force = 200f;
  
  
    public void FireGun()
    {
        GameObject bulletobj = Instantiate(bullet, InstantiateSolo.child.transform.position, InstantiateSolo.child.transform.rotation);
        bulletobj.GetComponent<Rigidbody>().AddForce(InstantiateSolo.child.transform.forward * -force);
    }

    
}
