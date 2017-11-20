using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class counter : MonoBehaviour {

    private int honor = 0;
    private int deshonra = 0;
    public string nextStage;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (honor == 3)
        {
			SceneManager.LoadScene ("Introduccion");
        }
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy"){
            if (collision.gameObject.GetComponent<life>().health == 0){
                honor++;
				GameManager.instance.score += 1000;
                Debug.Log("honor");
            }else{
                deshonra++;
                Debug.Log("deshonra");
            }
            Destroy (collision.gameObject);
        }
        
    }
}
