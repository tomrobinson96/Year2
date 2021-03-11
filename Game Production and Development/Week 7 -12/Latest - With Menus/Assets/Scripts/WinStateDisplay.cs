//SID:1311941
//Display player time on win conditon
using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class WinStateDisplay : MonoBehaviour 
{
	public Canvas WinState;
	public Canvas DeathState;
	public Button Replay;
	public Button ReturnToMenu;
	Text text;
    float time;
	// Use this for initialization
	void Start () 
	{
		Debug.Log ("Activated");
		WinState = WinState.GetComponent<Canvas> ();
		DeathState = DeathState.GetComponent<Canvas> ();
		Replay = Replay.GetComponent<Button> ();
		ReturnToMenu = ReturnToMenu.GetComponent<Button> ();
		GameObject obj = GameObject.Find("ScoreDisplay");
        text = obj.GetComponent <Text>();

	}

	void ShowTime(float i)
	{
		Debug.Log ("Time should show");
		time = i;
		text.text = string.Format ("Completion Time: {0:#.00} ", time);       
        
    }



	void OnTriggerEnter(Collider other)
	{
		
		WinState.enabled = true;
		
	}

	public void ReplayLevel () //Restarts Level
	{
		Application.LoadLevel(Application.loadedLevel);
	}
	
	public void ReturnToMenuButton() //Loads Main Menu
	{
		Application.LoadLevel("MainMenu");
		
	}


}
