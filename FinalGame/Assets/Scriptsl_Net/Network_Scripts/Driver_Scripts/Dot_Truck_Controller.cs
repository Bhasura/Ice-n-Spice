using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class Dot_Truck : System.Object
{
	public WheelCollider leftWheel;
	public GameObject leftWheelMesh;
	public WheelCollider rightWheel;
	public GameObject rightWheelMesh;
	public bool motor;
	public bool steering;
	public bool reverseTurn;
    
}

public class Dot_Truck_Controller : MonoBehaviour {

	public float maxMotorTorque;
	public float maxSteeringAngle;
	public List<Dot_Truck> truck_Infos;
    
    public MoveButton m ;
    public float motor1;
    public float engine;
    
    public bool pointer = false;

    //public float accel_x;

    public void VisualizeWheel(Dot_Truck wheelPair)
	{
		Quaternion rot;
		Vector3 pos;
		wheelPair.leftWheel.GetWorldPose ( out pos, out rot);
		wheelPair.leftWheelMesh.transform.position = pos;
		wheelPair.leftWheelMesh.transform.rotation = rot;
		wheelPair.rightWheel.GetWorldPose ( out pos, out rot);
		wheelPair.rightWheelMesh.transform.position = pos;
		wheelPair.rightWheelMesh.transform.rotation = rot;
	}
    
    public void Update()
	{
        //accel_x = Input.acceleration.x * 50;
        //transform.RotateAround(transform.position, transform.up, accel_x * Time.deltaTime);


         
		float steering = maxSteeringAngle * Input.acceleration.x * 2;
        float brakeTorque = Mathf.Abs(Input.GetAxis("Jump"));

		if (brakeTorque > 0.001) {
			brakeTorque = maxMotorTorque;
			motor1 = 0;
		} else {
			brakeTorque = 0;
		}

		foreach (Dot_Truck truck_Info in truck_Infos)
		{
			if (truck_Info.steering == true) {
				truck_Info.leftWheel.steerAngle = truck_Info.rightWheel.steerAngle = ((truck_Info.reverseTurn)?-1:1)*steering;
			}

			if (truck_Info.motor == true )
			{
                
                truck_Info.leftWheel.motorTorque = m.carSpeed;
				truck_Info.rightWheel.motorTorque = m.carSpeed;


			}
         
            
			truck_Info.leftWheel.brakeTorque = brakeTorque;
			truck_Info.rightWheel.brakeTorque = brakeTorque;

			VisualizeWheel(truck_Info);
		}

	}


}