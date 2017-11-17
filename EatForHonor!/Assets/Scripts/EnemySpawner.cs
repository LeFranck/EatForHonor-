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
	public int X = 0;
	public int Y = 0;

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
                waveCountdown = 4f;
                state = SpawnState.COUNTING;
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
                //Posiblw cagaso
                waveCountdown = 4f;
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
			yield return new WaitForSeconds(5f/wave.rate);
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
		Vector3 a = transform.position;
		a.x = a.x + X;
		a.y = a.y + Y;
		Instantiate (enemy, a, transform.rotation);
	}


}
