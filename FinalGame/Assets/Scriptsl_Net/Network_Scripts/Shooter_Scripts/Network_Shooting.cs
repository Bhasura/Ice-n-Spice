using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Network_Shooting : MonoBehaviour
{
    public Rigidbody icecreamBullet;
    public float force = 200f;

    /*
  private void Start()
  {
      carTemp = car.position;
      turretTemp = turret.rotation;

  }


  public void Update()
  {
      carTemp = car.position;
      turretTemp = turret.rotation;
      print(turretTemp);

  }
  */
    public void networkFire()
    {
        
        //ice = Instantiate(icecreamBullet, GunEnd.position, GunEnd.rotation) as Rigidbody;
        //ice = PhotonNetwork.Instantiate(icecreamBullet.name, temp, GunEnd.rotation) as Rigidbody;
        GameObject bullet = PhotonNetwork.Instantiate(icecreamBullet.name, Room_Controller.child1.transform.position , Room_Controller.child1.transform.rotation );
        // ice.velocity = transform.forward * force;
        bullet.GetComponent<Rigidbody>().AddForce(Room_Controller.child1.transform.forward * -force);
       // bullet.GetComponent<Rigidbody>().AddForceAtPosition(Room_Controller.child1.transform.position * force, Room_Controller.child1.transform.position);

    }
}
