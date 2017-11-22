using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonSpawner : MonoBehaviour {
	
	public int TipoDePersona;
	public Transform SpawnPos;
	//public SpriteRenderer sr;

	void OnMouseDown() {
		PersonSpawn();
	}

	public void PersonSpawn()
	{
		Instantiate (GameManager.instance.TiposPersonas[TipoDePersona], SpawnPos.position, SpawnPos.rotation);
		GameManager.instance.PersonTaken = TipoDePersona;
		GameManager.instance.PersonasPermitidas [TipoDePersona] -= 1;
	}

	// Use this for initialization

	void Awake(){
		Debug.Log ("hola, soy awake");
		gameObject.transform.localScale = new Vector3 (0.3f,0.3f,1f);

	}

	void Start () {
	}

	// Update is called once per frame
	void Update () {

	}
}
