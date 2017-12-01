using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class music_soundButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void turnOffSound (){
		SoundManager.instance.sound.mute = !SoundManager.instance.sound.mute;
		SoundManager.instance.soundFood.mute = !SoundManager.instance.soundFood.mute;
	}

	public void turnOffMusic (){
		SoundManager.instance.music.mute = !SoundManager.instance.music.mute;
	}
}
