using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeginActs : MonoBehaviour {

	public GameObject[] FoodSpawners;

	void OnMouseDown()
	{
		SoundManager.instance.soundFood.clip = GameManager.instance.clickea;
		SoundManager.instance.soundFood.Play ();
		for (int i = 0; i < FoodSpawners.Length; i++) 
		{
			FoodSpawners [i].GetComponent<EnemySpawner> ().enabled = true;
			Debug.Log("foodspawner");
		}
		Destroy (gameObject.GetComponent<SpriteRenderer>());
	}

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		int check = 0;
		for (int i = 0; i < FoodSpawners.Length; i++) 
		{
			if (FoodSpawners[i].GetComponent<EnemySpawner>().nextWave >= FoodSpawners[i].GetComponent<EnemySpawner>().waves.Length)
			{
				check += 1;
			}
		}
		if (check == FoodSpawners.Length) 
		{
			GameManager.instance.HasWaves = false;
		}
	}
}
