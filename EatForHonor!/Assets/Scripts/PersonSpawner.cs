using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonSpawner : MonoBehaviour {
	
	public Transform TipoPersona;
	public int option = -1;
	public bool showing = false;

	void OnMouseDown() {
		if (showing) {
			//Stopshowgin
			showing = false;
		} else if(option != -1){
			//int option = ShowOptions
			//StopShowingOptions
		}
	}

	public void PersonSpawn(Transform person)
	{
		Instantiate (person, transform.position, transform.rotation);
		Destroy (this);
	}

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
}
