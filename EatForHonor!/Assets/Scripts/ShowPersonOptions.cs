using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPersonOptions : MonoBehaviour {

	public GameObject[] spawners;

	//Agregar caso se aprieta otra silla, con nombre o tag del objeto
	void OnMouseDown() 
	{
		Debug.Log("Me aprietan!!!");
		if (GameManager.instance.CanShowPersons) 
		{
			bool showing = GameManager.instance.ShowingPersons;
			if (showing) 
			{
				for (int i = 0; i < spawners.Length; i++) 
				{
					if(spawners[i] != null)
						Destroy (spawners [i]);
				}
				GameManager.instance.ShowingPersons = false;
				Debug.Log ("Destrui los spawners");
			} 
			else if (GameManager.instance.PersonTaken == -1) 
			{
				for (int i = 0; i < GameManager.instance.PersonasPermitidas.Length; i++) 
				{
					if (GameManager.instance.PersonasPermitidas [i] > 0) 
					{
						GeneratePersonSpawner (i);
					}
				}
				GameManager.instance.ShowingPersons = true;
				Debug.Log ("genere los spawners");
			} 
		}
	}

	public void GeneratePersonSpawner(int i){
		Vector3 pos = new Vector3(transform.position.x, transform.position.y, 0);
		if (i == 0) {
			pos += new Vector3 (2, 2, 0);
		} else if (i == 1) {
			pos += new Vector3 (2, -2, 0);
		} else if (i == 2) {
			pos += new Vector3 (-2, -2, 0);
		} else {
			pos += new Vector3 (-2, 2, 0);
		}
		spawners[i] = new GameObject ();
		spawners[i].transform.position = pos;
		spawners[i].AddComponent<PersonSpawner>();
		spawners[i].GetComponent<PersonSpawner>().SpawnPos = transform;
		spawners[i].GetComponent<PersonSpawner>().TipoDePersona = i;

		Debug.Log("Le le le!!!");
		SpriteRenderer sr = GameManager.instance.TiposPersonas[i].GetComponent<SpriteRenderer> ();
		spawners[i].AddComponent<SpriteRenderer>();
		spawners[i].GetComponent<SpriteRenderer>().sprite = sr.sprite;
		spawners[i].AddComponent<BoxCollider2D>();
		//spawners[i].GetComponent<BoxCollider2D>()
		Debug.Log("Instancie al crio!!!");


		//Instantiate(spawners[i], new Vector3(pos.x, pos.y, 0), transform.rotation);
	}

	// Use this for initialization
	void Start () {
		spawners = new GameObject[4];
		//for (int j = 0; j < spawners.Length; j++) {
		//	spawners[j] = new GameObject ();
		//}
		Debug.Log("inicialize Spawners vaciooo!!!");
	}
	
	// Update is called once per frame
	void Update () {
		//Se ha generado una persona desde los personsSpawners creeados aca
		if (GameManager.instance.PersonTaken != -1) {
			for (int i = 0; i < spawners.Length; i++) 
			{
				if(spawners[i] != null)
					Destroy (spawners [i]);
			}
			GameManager.instance.ShowingPersons = false;
			GameManager.instance.PersonTaken = -1;
		}
		
	}
}
