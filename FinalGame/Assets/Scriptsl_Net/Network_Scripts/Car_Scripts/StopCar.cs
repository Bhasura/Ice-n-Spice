using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class StopCar : MonoBehaviour, IPointerDownHandler
{
    public virtual void OnPointerDown(PointerEventData p)
    {

        InstantiateSolo.truckDef.GetComponent<Rigidbody>().velocity = Vector3.zero;



    }
}
