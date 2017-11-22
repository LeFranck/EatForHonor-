using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashActs : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag == "Enemy"){
			if (collision.gameObject.GetComponent<life>().health == 0){
				GameManager.instance.honor += 1;
				GameManager.instance.Info.transform.Find("txtHonor").GetComponent<TextMesh>().text = GameManager.instance.honor+"";
				GameManager.instance.score += 1000;
				Debug.Log("honor");
			}else{
				GameManager.instance.deshonor += 1;
				GameManager.instance.Info.transform.Find("txtDeshonor").GetComponent<TextMesh>().text = GameManager.instance.deshonor+"";
				Debug.Log("deshonra");
			}
			Destroy (collision.gameObject);
		}

	}
}
