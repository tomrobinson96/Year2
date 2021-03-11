// SID: 1431440
// Script to propel the ship forward at a constant force, and 
//for the player to move the ship to the left or right.

using UnityEngine;
using UnityEngine.UI; //SID 1221628
using System.Collections;

public class Planemovement : MonoBehaviour {
	
	// Constant thrust forwards (Z axis)
	public float forwardThrust;
	// Speed when player strafes left or right (y axis)
	public float strafeSpeed;
	//Max speed of movement
	public float maxSpeed;
	// Rotation when the character strafes
	public float tilt;
	
	public Rigidbody planeRigidbody; 
	//SID 1221628 contribution begins - UI Elements added

	//SID 1221628 contribution Ends - UI Elements added
	void Start ()
	{
		planeRigidbody = GetComponent<Rigidbody>();
	}
	
	
	
	void Update () {
		// Side-to-side velocity reliant on player input
		float strafe = Input.GetAxis("Horizontal") * strafeSpeed;
		// Plane moves forward under the forward thrust, and side-to-side based upon player input
		planeRigidbody.AddForce(strafe,0,forwardThrust, ForceMode.Force);
		//Plane tilts as it moves left or right
		planeRigidbody.rotation = Quaternion.Euler(0.0f, 0.0f, Mathf.Clamp(planeRigidbody.velocity.x * -tilt, -50.0f, 50.0f));
		// Limit max speed
		if (planeRigidbody.velocity.sqrMagnitude > (maxSpeed * maxSpeed))
		{
			planeRigidbody.velocity = planeRigidbody.velocity.normalized * maxSpeed;
		}
		
	}

	
	void LateUpdate()
	{
		if (planeRigidbody.velocity.z < 1 && Time.timeSinceLevelLoad > 1.0f)  //If further forward movement is obstructed (hit an object), the ship 'crashes'
		{
			GameObject obj = GameObject.Find("Control");
			obj.SendMessage("PlayerFailState");
			gameObject.active= false;

		}
		

	}

}
