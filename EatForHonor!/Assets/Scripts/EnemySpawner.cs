using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

	public enum SpawnState { SPAWNING, WAITING, COUNTING}

	private int nextWave = 0;
	private float searchCountdown = 3f;
	private SpawnState state = SpawnState.COUNTING;

	public Wave[] waves;
	public float timeBetweenWaves = 5f;
	public float waveCountdown;

	void Start()
	{
		waveCountdown = timeBetweenWaves;
	}

	void Update()
	{
		if (state == SpawnState.WAITING) 
		{
			if (!EnemyIsAlive ()) 
			{
				//new wave
				Debug.Log("wave completed");
			}
			else
			{
				return;
			}
		}


		if (waveCountdown <= 0f) 
		{
			if (state != SpawnState.SPAWNING) 
			{
				StartCoroutine (SpawnWave (waves [nextWave]));
			}
		}
		else 
		{
			waveCountdown -= Time.deltaTime;	
		}

	}

	IEnumerator SpawnWave(Wave wave)
	{
		Debug.Log("Spawnin wave "+ wave.name);
		state = SpawnState.SPAWNING;

		for (int i = 0; i < wave.count; i++) 
		{
			SpawnEnemy (wave.enemy);
			yield return new WaitForSeconds(1f/wave.rate);
		}

		state = SpawnState.WAITING;
		yield break;
	}

	bool EnemyIsAlive()
	{
		searchCountdown -= Time.deltaTime;
		if (searchCountdown <= 0f) 
		{
			searchCountdown = 1f;
			if (GameObject.FindGameObjectWithTag ("Enemy") == null) 
			{
				return false;			
			}
		}
		return true;
	}

	void SpawnEnemy(Transform enemy)
	{
		Debug.Log("Spawing enemy " + enemy.name);
		Instantiate (enemy, transform.position, transform.rotation);
	}


}
