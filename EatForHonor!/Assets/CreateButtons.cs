using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateButtons : MonoBehaviour {

    public GameObject man;
    public GameObject woman;
    public GameObject boy;
    public GameObject girl;
    
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    public void CreateMan() {
        Instantiate(man, new Vector3(0, 0, 0), Quaternion.identity);
    }

    public void CreateWoman()
    {
        Instantiate(woman, new Vector3(0, 0, 0), Quaternion.identity);
    }

    public void CreateBoy()
    {
        Instantiate(boy, new Vector3(0, 0, 0), Quaternion.identity);
    }

    public void CreateGirl()
    {
        Instantiate(girl, new Vector3(0, 0, 0), Quaternion.identity);
    }
}
