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
    public Sprite[] mascadas = new Sprite[5];
    private int x = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (countdownCheck <= 0f) {
			if (comiendo) {
				comiendo = false;
				transform.GetComponent<SpriteRenderer> ().sprite = spriteNormal;
				transform.GetComponent<CircleCollider2D> ().radius = transform.GetComponent<CircleCollider2D> ().radius * 3;
			} 
			countdownCheck = 4f;

		} else {
			countdownCheck -= Time.deltaTime;
		}

        if (comiendo)
        {
            if (variableBerru <= 0f)
            {
                state = !state;
                if (state)
                {
                    transform.GetComponent<SpriteRenderer>().sprite = spriteComiendo;
                }
                else
                {
                    transform.GetComponent<SpriteRenderer>().sprite = spriteNormal;
                }
                variableBerru = 0.5f;
            }
            else
            {
                variableBerru -= Time.deltaTime;
            }
            if (clock <= 0f)
            {
                if (x < 4)
                {
                    x += 1;
                    plate.GetComponent<SpriteRenderer>().sprite = mascadas[x];
                }
                else
                {
                    x = 0;
                    Destroy(plate.GetComponent<SpriteRenderer>().sprite);
                }
                clock = 0.98f;
            }
            else
            {
                clock -= Time.deltaTime;
            }
        }
			
	}


}
