using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateButtons : MonoBehaviour
{

    public GameObject man;
    public GameObject woman;
    public GameObject boy;
    public GameObject girl;
    public Transform canvas;
    //public Transform self;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CreateMan()
    {
        Instantiate(man, new Vector3(transform.position.x + transform.localScale.x / 2 + man.transform.localScale.x / 2, transform.position.y + transform.localScale.y / 2 + man.transform.localScale.y / 2, 0), Quaternion.identity, canvas);
    }

    public void CreateWoman()
    {
        Instantiate(woman, new Vector3(transform.position.x - transform.localScale.x / 2 - woman.transform.localScale.x / 2, transform.position.y + transform.localScale.y / 2 + woman.transform.localScale.y / 2, 0), Quaternion.identity, canvas);
    }

    public void CreateBoy()
    {
        Instantiate(boy, new Vector3(transform.position.x + transform.localScale.x / 2 + boy.transform.localScale.x / 2, transform.position.y - transform.localScale.y / 2 - boy.transform.localScale.y / 2, 0), Quaternion.identity, canvas);
    }

    public void CreateGirl()
    {
        Instantiate(girl, new Vector3(transform.position.x - transform.localScale.x / 2 - girl.transform.localScale.x / 2, transform.position.y - transform.localScale.y / 2 - girl.transform.localScale.y / 2, 0), Quaternion.identity, canvas);
    }

}