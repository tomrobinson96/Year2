//SID:1311941
//Ends level timer and starts the saving highscore
using UnityEngine;
using System.Collections;

public class SendScore : MonoBehaviour
{
	GameObject timer;
	//Finds
	void Awake()
	{
		timer = GameObject.Find ("Canvas/Text");
	}
    //
    void OnTriggerEnter(Collider col)
    { 
		if (col.tag == "Player") 
		{
			Debug.Log ("Sent score message");
			timer.SendMessage ("SendScore");
		}
    }
   	
}
