using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class apretalo : MonoBehaviour {

	void OnMouseDown() {
		transform.localScale += new Vector3(0.4F, 0, 0);
		Debug.Log ("ME apretaste :(");
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
