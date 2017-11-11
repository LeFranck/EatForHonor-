using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodActs : MonoBehaviour {

	public enum FoodState { ZERO, UNO, DOS, TRES, CUATRO}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag == "persona") 
		{
			Debug.Log ("chocooo debe comer");
		}
	}
}
