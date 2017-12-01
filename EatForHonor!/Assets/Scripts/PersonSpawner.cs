using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PersonSpawner : MonoBehaviour {
	
	public int TipoDePersona;
    public Transform SpawnPos;
    public GameObject plate;
	//public SpriteRenderer sr;

	void OnMouseDown() {
		PersonSpawn();
	}

	public void PersonSpawn()
	{
		GameObject x = Instantiate (GameManager.instance.TiposPersonas[TipoDePersona], SpawnPos.position, SpawnPos.rotation);
        x.GetComponent<PersonActs>().plate = plate;
        GameManager.instance.PersonTaken = TipoDePersona;
		GameManager.instance.PersonasPermitidas [TipoDePersona] -= 1;
		string TextName = String.Concat ("txt", TipoDePersona+1);
		GameManager.instance.Info.transform.Find (TextName).GetComponent<TextMesh> ().text = GameManager.instance.PersonasPermitidas [TipoDePersona]+"";
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
