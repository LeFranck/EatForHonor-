using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodActs : MonoBehaviour {

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
		if (collision.gameObject.tag == "Persona") 
		{
			if (collision.transform.GetComponent<PersonActs> ().comiendo != true) {
				collision.transform.GetComponent<PersonActs>().comiendo = true;
				collision.transform.GetComponent<SpriteRenderer> ().sprite = collision.transform.GetComponent<PersonActs> ().spriteComiendo;
				collision.transform.GetComponent<PersonActs> ().countdownCheck = 5f;
				collision.transform.GetComponent<CircleCollider2D> ().radius = collision.transform.GetComponent<CircleCollider2D> ().radius / 3;
				transform.GetComponent<life>().health -= 1;
				int vida = transform.GetComponent<life>().health;
				if (vida == 3) {
					transform.GetComponent<SpriteRenderer>().sprite = one_hit;
				} else if (vida == 2) {
					transform.GetComponent<SpriteRenderer>().sprite = two_hits;
				} else if (vida == 1) {
					transform.GetComponent<SpriteRenderer>().sprite = three_hits;
				} else {
					transform.GetComponent<SpriteRenderer>().sprite = four_hits;
					transform.localScale -= new Vector3 (transform.position.x * 0.2F, transform.position.y * 0.2F,0F);
					//transform.localScale += new Vector3(0.1F, 0, 0);

				}
			}

		}else {
			Debug.Log ("WOOOOLA");
		}
	}
}
