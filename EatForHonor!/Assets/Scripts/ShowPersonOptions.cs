using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPersonOptions : MonoBehaviour {

	public GameObject[] spawners = new GameObject[4];

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
				showing = false;
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
			} 
		}
	}

	public void GeneratePersonSpawner(int i){
		Vector3 pos = new Vector3(transform.position.x, transform.position.y, 0);
		if (i == 0) {
			pos += new Vector3 (3, 3, 0);
		} else if (i == 1) {
			pos += new Vector3 (3, -3, 0);
		} else if (i == 2) {
			pos += new Vector3 (-3, -3, 0);
		} else {
			pos += new Vector3 (-3, 3, 0);
		}
		spawners[i] = new GameObject ();
		spawners[i].transform = pos;
		
		//Instantiate(mono, new Vector3(chair.transform.position.x, chair.transform.position.y, 0), chair.transform.rotation);

	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//Se ha generado una persona desde los personsSpawners creeados aca
		if (GameManager.instance.PersonTaken != -1) {
			
		}
		
	}
}
