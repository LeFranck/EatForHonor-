using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonActs : MonoBehaviour {

	public bool comiendo = false;
	public float countdownCheck = 4f;
	public Sprite spriteComiendo;
	public Sprite spriteNormal;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (countdownCheck <= 0f) {
			if (comiendo) {
				comiendo = false;
				transform.GetComponent<SpriteRenderer> ().sprite = spriteNormal;
			} 
			countdownCheck = 4f;
		} else {
			countdownCheck -= Time.deltaTime;
		}
			
	}


}
