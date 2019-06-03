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
        GameObject bullet1 = PhotonNetwork.Instantiate(icecreamBullet.name, Room_Controller.child1.transform.position, Room_Controller.child1.transform.rotation);
        bullet1.GetComponent<Rigidbody>().AddForce(Room_Controller.child1.transform.forward * -force);


        GameObject bullet2 = PhotonNetwork.Instantiate(icecreamBullet.name, Room_Controller.child2.transform.position, Room_Controller.child2.transform.rotation);
        bullet2.GetComponent<Rigidbody>().AddForce(Room_Controller.child2.transform.forward * -force);
    }
}
