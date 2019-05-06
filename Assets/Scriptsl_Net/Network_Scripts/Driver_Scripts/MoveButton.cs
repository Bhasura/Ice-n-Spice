using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoveButton : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    public bool isPointerDown = false;
    public float carSpeed = 0;
    
   

    
    public virtual void OnPointerUp(PointerEventData p)
    {
        carSpeed = 0;
        isPointerDown = false;
       
    }

    public virtual void OnPointerDown(PointerEventData p)
    {
        carSpeed = 100;
        isPointerDown = true;
        
        

    }

    public float accelerateCar()
    {
        if(isPointerDown == true)
        {
            carSpeed = 100;
          
        }
        else
        {
            carSpeed = 0;
            
        }
        return carSpeed;
    }
}
