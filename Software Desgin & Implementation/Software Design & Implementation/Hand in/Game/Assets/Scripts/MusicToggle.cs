using UnityEngine;
using System.Collections;

public class MusicToggle: MonoBehaviour{
	
	bool isMute;
	
	
	public void MusicMute (){
		if(isMute == true){
			Debug.Log("Music On");
			AudioListener.volume = 1;
			isMute = false;
		}
		else {
			Debug.Log("Music Off");
			isMute = true;
			AudioListener.volume = 0;
		}
	}   
}