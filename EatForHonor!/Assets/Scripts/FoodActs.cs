using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodActs : MonoBehaviour {

	public enum FoodState { ZERO, UNO, DOS, TRES, CUATRO}
	public Sprite one_hit;
	public Sprite two_hits;
	public Sprite three_hits;
	public Sprite four_hits;
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
			collision.transform.GetComponent<PersonActs>().comiendo = true;
			transform.GetComponent<life>().health = 1;
			int vida = transform.GetComponent<life>().health;
			if (vida == 3) {
				transform.GetComponent<SpriteRenderer>().sprite = one_hit;
			} else if (vida == 2) {
				transform.GetComponent<SpriteRenderer>().sprite = two_hits;
			} else if (vida == 1) {
				transform.GetComponent<SpriteRenderer>().sprite = three_hits;
			} else {
				transform.GetComponent<SpriteRenderer>().sprite = four_hits;
			}
		}else {
			Debug.Log ("WOOOOLA");
		}
	}
}
