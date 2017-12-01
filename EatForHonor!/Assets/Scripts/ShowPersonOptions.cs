using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPersonOptions : MonoBehaviour {

	public GameObject[] spawners;
    public GameObject plate;
	//Agregar caso se aprieta otra silla, con nombre o tag del objeto
	void OnMouseDown() 
	{
		Debug.Log("Me aprietan!!!");

		//Generar spawners y setear sillaUsada
		if (GameManager.instance.SillaUsada == "") {
			for (int i = 0; i < GameManager.instance.PersonasPermitidas.Length; i++) 
			{
				if (GameManager.instance.PersonasPermitidas [i] > 0) 
				{
					GeneratePersonSpawner(i);
				}
			}
			GameManager.instance.SillaUsada = gameObject.name;
			Debug.Log ("genere los spawners");
		}
		else if(GameManager.instance.SillaUsada == gameObject.name)  //Destruir spawners y setear SillaUsada a ""
		{
			for (int i = 0; i < spawners.Length; i++) 
			{
				if(spawners[i] != null)
					Destroy(spawners[i]);
			}
			GameManager.instance.SillaUsada = "";
			Debug.Log ("Destrui los spawners de "+gameObject.name);
		}

	}


	public void GeneratePersonSpawner(int i){
		Vector3 pos = new Vector3(transform.position.x, transform.position.y, 0);
		if (i == 0) {
			pos += new Vector3 (2, 2, -2);
		} else if (i == 1) {
			pos += new Vector3 (2, -2, -2);
		} else if (i == 2) {
			pos += new Vector3 (-2, -2, -2);
		} else {
			pos += new Vector3 (-2, 2, -2);
		}

		spawners[i] = new GameObject ();
		spawners[i].transform.position = pos;
		spawners[i].AddComponent<PersonSpawner>();
		spawners[i].GetComponent<PersonSpawner>().SpawnPos = transform;
		spawners[i].GetComponent<PersonSpawner>().TipoDePersona = i;
        spawners[i].GetComponent<PersonSpawner>().plate = plate;

        SpriteRenderer sr = GameManager.instance.TiposPersonas[i].GetComponent<SpriteRenderer> ();
		spawners[i].AddComponent<SpriteRenderer>();
		spawners[i].GetComponent<SpriteRenderer>().sprite = sr.sprite;
		spawners[i].GetComponent<SpriteRenderer>().sortingOrder = 20;
		spawners[i].AddComponent<BoxCollider2D>();
	}

	// Use this for initialization
	void Start () {
		spawners = new GameObject[4];
		//Debug.Log("inicialize Spawners vaciooo!!!");
	}
	
	// Update is called once per frame
	void Update () {
		//Se ha generado una persona desde los personsSpawners creeados aca
		if (GameManager.instance.PersonTaken != -1 && GameManager.instance.SillaUsada == gameObject.name) {
			for (int i = 0; i < spawners.Length; i++) 
			{
				if(spawners[i] != null)
					Destroy (spawners[i]);
			}
			GameManager.instance.PersonTaken = -1;
			GameManager.instance.SillaUsada = "";
			Vector3 pos = new Vector3(transform.position.x, transform.position.y, -10);
			transform.position = pos;

			Destroy (this);
		}
		
	}
}
