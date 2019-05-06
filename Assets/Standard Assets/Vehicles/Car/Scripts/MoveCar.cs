using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoveCar : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    public bool isPointerDown = false;
    public float carSpeed = 0;




    public virtual void OnPointerUp(PointerEventData p)
    {
        
        isPointerDown = false;

    }

    public virtual void OnPointerDown(PointerEventData p)
    {
        
        isPointerDown = true;



    }

    public float accelerateCar()
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
    }
}