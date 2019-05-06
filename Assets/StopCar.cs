using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class StopCar : MonoBehaviour, IPointerDownHandler
{
    public GameObject car;
    public virtual void OnPointerDown(PointerEventData p)
    {

        car.GetComponent<Rigidbody>().velocity = Vector3.zero;



    }
}
