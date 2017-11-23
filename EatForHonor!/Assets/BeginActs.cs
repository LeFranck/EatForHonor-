using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeginActs : MonoBehaviour {

	public GameObject[] FoodSpawners;

	void OnMouseDown()
	{
		for (int i = 0; i < FoodSpawners.Length; i++) 
		{
			FoodSpawners [i].GetComponent<EnemySpawner> ().enabled = true;
			Debug.Log("foodspawner");
		}
		Destroy (gameObject);
	}

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
