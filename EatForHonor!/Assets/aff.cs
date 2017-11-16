using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aff : MonoBehaviour {

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            Debug.Log("chocooo debe comer");
        }
        else
        {
            Debug.Log("WOOOOLA");
        }
        
    }
}
