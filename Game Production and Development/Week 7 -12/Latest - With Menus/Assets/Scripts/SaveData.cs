using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SaveData : MonoBehaviour 
	//SID:1311941
	//This class saves data given to it from the game world
	//Currently it can only save data on the players High Score


{
	public Canvas WinState;
	float highScore;
	float lastRun;
    Text text;
    
    // Use this for initialization
    void Start () 
	{
		WinState.enabled = false;

        GameObject obj = GameObject.Find("HighscoreDisplay");
        text = obj.GetComponent<Text>();

        if (PlayerPrefs.HasKey("score"))
		{
			highScore = PlayerPrefs.GetFloat("score");
			Debug.Log("High Score = "+ highScore);
		}
		else
		{
			PlayerPrefs.SetFloat("score",999);
			Debug.Log("Created score");
		}

		if (PlayerPrefs.HasKey("lapTime"))
		{
			Debug.Log("last run time" +lastRun );
		}
		else
		{
			PlayerPrefs.SetFloat("lapTime",0);
			Debug.Log("Created lapTime");
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	//Recives HighScore from game and checks it against current highscore
	void CheckHighScore(int compare)
	{
		lastRun = compare;
		WinState.enabled = true;
		GameObject obj = GameObject.Find ("WinState");
		obj.SendMessage ("ShowTime",lastRun);

		Debug.Log("Player Time = "+ compare);
		Debug.Log("High Score = "+ highScore);


		if (compare < highScore)
		{
			highScore = compare;
			Debug.Log("High Score = "+ highScore);
			SetHighScore(highScore);
            ShowHighscore(highScore);
		}
		else
		{
			Debug.Log("New score was equal or more than current Highscore");
		}
	}

	void SetHighScore(float temp)
	{
		highScore = temp;
		SaveHighScore();
	}

	void SaveHighScore()
	{
		PlayerPrefs.SetFloat("score",highScore);
		PlayerPrefs.Save();
		Debug.Log("High Score = "+ highScore);
	}

    void ShowHighscore(float i)
    {
        Debug.Log("Highcore should show");
        highScore = i;
        text.text = string.Format("Track Record: {0:#.00} ", highScore);
    }

}
