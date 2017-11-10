using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonSpawner : MonoBehaviour {


	public void PersonSpawn(Transform person)
	{
		Instantiate (person, transform.position, transform.rotation);
		Destroy (this);
	}

	public void Peopeo(Transform person)
	{
		Instantiate (person, transform.position, transform.rotation);
		Destroy (this);
	}

	public void DestruirObjeto(string nametag)
	{
		GameObject cosa = GameObject.FindGameObjectWithTag("nametag");
		Destroy (cosa);
	}

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
}
