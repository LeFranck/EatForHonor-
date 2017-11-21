using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonSpawner : MonoBehaviour {
	
	public GameObject TipoPersona;
	public Transform spawnPos;
	public Sprite sprite;

	void OnMouseDown() {
		PersonSpawn();
	}

	public void PersonSpawn()
	{
		Instantiate (TipoPersona, transform.position, transform.rotation);
	}

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
}
