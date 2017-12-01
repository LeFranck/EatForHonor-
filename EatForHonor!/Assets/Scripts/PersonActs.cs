using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonActs : MonoBehaviour {

	public bool comiendo = false;

	public Sprite spriteComiendo;
	public Sprite spriteNormal;
	public float countdownCheck = 4f;
	public float RcountdownCheck = 4f;
	public float variableBerru = 0.5f;
	public float RvariableBerru = 0.5f;
	public float clock = 0.98f;
	public float Rclock = 0.98f;
    public bool state = true;
	public GameObject plate;
	public GameObject plateVacio;
    public Sprite[] mascadas = new Sprite[5];
    private int x = 0;
	public AudioClip biteSound;
	public AudioClip burp;
	// Use this for initialization
	void Start () {
		if (gameObject.name.Contains("MexicanBoy")) {
			countdownCheck = 3.5f;
			RcountdownCheck = 3.5f;
			variableBerru = 0.3f;
			RvariableBerru = 0.3f;
			clock = 0.8f;
			Rclock = 0.8f;
		} else if (gameObject.name.Contains("MexicanMan")) {
			countdownCheck = 4f;
			RcountdownCheck = 4f;
			variableBerru = 0.5f;
			RvariableBerru = 0.5f;
			clock = 0.98f;
			Rclock = 0.98f;
		} else if (gameObject.name.Contains("MrxicanGirl")) {
			countdownCheck = 2.5f;
			RcountdownCheck = 2.5f;
			variableBerru = 0.2f;
			RvariableBerru = 0.2f;
			clock = 0.6f;
			Rclock = 0.6f;
		} else if (gameObject.name.Contains("Mexicanwoman")) {
			countdownCheck = 3f;
			RcountdownCheck = 3f;
			variableBerru = 0.3f;
			RvariableBerru = 0.3f;
			clock = 0.70f;
			Rclock = 0.70f;
		}
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
			countdownCheck = RcountdownCheck;

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
					SoundManager.instance.sound.clip = biteSound;
					SoundManager.instance.sound.Play ();
				}
				variableBerru = RvariableBerru;
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
				clock = Rclock;
			} else {
				clock -= Time.deltaTime;
			}
		} else {
			clock = Rclock;
		}

		if ((Random.Range (0, 15000) < 1) && comiendo && gameObject.name == "MexicanMan"){
			SoundManager.instance.sound.clip = burp;
			SoundManager.instance.sound.Play ();
		}
			
	}


}
