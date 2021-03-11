//SID:1311941
//Sends message to check and/or save new highscore
using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class GameTimer : MonoBehaviour 
{
	public static float timer;
    public GameObject control;  
	bool stop;
	Text stext;
	// Update is called once per frame
	void Awake()
	{
		timer = 0; 
		stop = false;
		stext = GetComponent <Text>();
	}


	void Update () 
	{
		//while (stop == false)
		//{
		timer += Time.deltaTime;
		stext.text = string.Format("Time: {0:#.00} ",  timer);
		//}
	}

	void SendScore()
	{
		stop = true;
		control.SendMessage("CheckHighScore", timer);
	}
}
