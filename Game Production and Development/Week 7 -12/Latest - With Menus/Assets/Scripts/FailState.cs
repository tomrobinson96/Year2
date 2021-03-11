//SID:1311941
using UnityEngine;
using System.Collections;

public class FailState : MonoBehaviour 
{
	public Canvas fail;
    public Canvas WinState;

    void Start()
	{
		fail.enabled = false;
        // 1409046 input started
        WinState = WinState.GetComponent<Canvas>();
        // 1409046 input ended
    }

	void PlayerFailState()
	{
        // 1409046 input started
        if (WinState.enabled == true)
        {
            fail.enabled = false;
        }
        else
       // 1409046 input ended
       fail.enabled = true;
	}
}
