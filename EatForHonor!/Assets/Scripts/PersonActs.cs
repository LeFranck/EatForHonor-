using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonActs : MonoBehaviour {

	public bool comiendo = false;
	public float countdownCheck = 4f;
	public Sprite spriteComiendo;
	public Sprite spriteNormal;
    public float variableBerru = 0.5f;
	public float clock = 0.98f;
    public bool state = true;
	public GameObject plate;
	public GameObject plateVacio;
    public Sprite[] mascadas = new Sprite[5];
    private int x = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (countdownCheck <= 0f) {
			x = 0;
			if (comiendo) {
				comiendo = false;
				transform.GetComponent<SpriteRenderer> ().sprite = spriteNormal;
				transform.GetComponent<CircleCollider2D> ().radius = transform.GetComponent<CircleCollider2D> ().radius * 3;
			} 
			countdownCheck = 4f;

		} else {
			countdownCheck -= Time.deltaTime;
		}

		if (comiendo) {
			//Tiempo de Mascada 
			if (variableBerru <= 0f) {
				state = !state;
				if (state) {
					transform.GetComponent<SpriteRenderer> ().sprite = spriteComiendo;
				} else {
					transform.GetComponent<SpriteRenderer> ().sprite = spriteNormal;
				}
				variableBerru = 0.5f;
			} else {
				variableBerru -= Time.deltaTime;
			}
			//Tiempo de plato en la mesa
			if (clock <= 0f) {
				//Valor asociado a la etapa del plato
				if (x < 4) {
					x += 1;
					plate.GetComponent<SpriteRenderer> ().sprite = mascadas [x];
				}
				clock = 0.98f;
			} else {
				clock -= Time.deltaTime;
			}
		} else {
			clock = 0.98f;
		}
			
	}


}
