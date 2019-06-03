using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoveCar : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    public bool isPointerDown = false;
    public static float carSpeed = 0;




    public virtual void OnPointerUp(PointerEventData p)
    {

        isPointerDown = false;
        carSpeed = 0;

    }

    public virtual void OnPointerDown(PointerEventData p)
    {

        isPointerDown = true;
        carSpeed = 0.1f;

    }


    /*public float accelerateCar()
    {
        if (isPointerDown == true)
        {
            carSpeed = 0.1f;

        }
        else
        {
            carSpeed = 0;

        }
        return carSpeed;
    }*/
}