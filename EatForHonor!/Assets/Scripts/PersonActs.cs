using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonActs : MonoBehaviour {

	public bool comiendo = false;
	public float countdownCheck = 4f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (countdownCheck <= 0f) {
			if (comiendo) {
				transform.localScale += new Vector3 (1f, 0, 0);
				comiendo = false;
			} else {
				transform.localScale = new Vector3 (3f, 3f, 1);
			}
			countdownCheck = 4f;
		} else {
			countdownCheck -= Time.deltaTime;
		}
			
	}


}
