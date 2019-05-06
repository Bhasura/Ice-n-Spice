using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnCollider : MonoBehaviour
{
    public GameObject car;
    public GameObject spawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        car.transform.position = spawnPoint.transform.position;
    }
}
