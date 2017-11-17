using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyChair : MonoBehaviour {

    public GameObject chair;
    public GameObject mono;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		 
	}

    public void OnClick()
    {
        Instantiate(mono, new Vector3(chair.transform.position.x, chair.transform.position.y, 0), chair.transform.rotation);
        Destroy(chair.GetComponent<CreateButtons>().manInstance);
        Destroy(chair.GetComponent<CreateButtons>().womanInstance);
        Destroy(chair.GetComponent<CreateButtons>().boyInstance);
        Destroy(chair.GetComponent<CreateButtons>().girlInstance);
        Destroy(chair);
    }
}
