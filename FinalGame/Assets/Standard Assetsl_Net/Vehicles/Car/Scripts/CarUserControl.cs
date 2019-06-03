using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof (CarController))]
    public class CarUserControl : MonoBehaviour
    {
        private CarController m_Car; // the car controller we want to use
        public MoveCar mc;

        private void Awake()
        {
            // get the car controller
            m_Car = GetComponent<CarController>();
        }


        private void FixedUpdate()
        {
            // pass the input to the car!
            float h = CrossPlatformInputManager.GetAxis("Horizontal");
            float v = CrossPlatformInputManager.GetAxis("Vertical");
            
            //float handbrake = CrossPlatformInputManager.GetAxis("Jump");
           // m_Car.Move(h, v, v, handbrake);

            h = Input.acceleration.x * 2;
            // v = mc.accelerateCar();
            v = MoveCar.carSpeed;
            m_Car.Move(h, v, v, 0f);



        }
    }
}
