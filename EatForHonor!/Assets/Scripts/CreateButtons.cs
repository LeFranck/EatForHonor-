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
    public GameObject boyInstance;
    public GameObject girlInstance;
    public GameObject manInstance;
    public GameObject womanInstance;

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
        if (transform.GetComponent<ReClick>().clicked)
        {
            Destroy(manInstance);
        }
        else
        {
            manInstance = Instantiate(man, new Vector3(transform.position.x + transform.localScale.x / 2 + man.transform.localScale.x / 2, transform.position.y + transform.localScale.y / 2 + man.transform.localScale.y / 2, 0), Quaternion.identity, canvas);
            //Debug.Log(transform.eulerAngles.z);
            //manInstance.transform.Rotate(new Vector3(0, 0, transform.eulerAngles.z));
            manInstance.GetComponent<MyChair>().chair = gameObject;
        }
        
    }

    public void CreateWoman()
    {
        if (transform.GetComponent<ReClick>().clicked)
        {
            Destroy(womanInstance);
        }
        else
        {
            womanInstance = Instantiate(woman, new Vector3(transform.position.x - transform.localScale.x / 2 - woman.transform.localScale.x / 2, transform.position.y + transform.localScale.y / 2 + woman.transform.localScale.y / 2, 0), Quaternion.identity, canvas);
            //womanInstance.transform.Rotate(new Vector3(0, 0, transform.eulerAngles.z));
            womanInstance.GetComponent<MyChair>().chair = gameObject;
        }
        
    }

    public void CreateBoy()
    {
        if (transform.GetComponent<ReClick>().clicked)
        {
            Destroy(boyInstance);
        }
        else
        {
            boyInstance = Instantiate(boy, new Vector3(transform.position.x + transform.localScale.x / 2 + boy.transform.localScale.x / 2, transform.position.y - transform.localScale.y / 2 - boy.transform.localScale.y / 2, 0), Quaternion.identity, canvas);
            //boyInstance.transform.Rotate(new Vector3(0, 0, transform.eulerAngles.z));
            boyInstance.GetComponent<MyChair>().chair = gameObject;
        }
        
    }

    public void CreateGirl()
    {
        if (transform.GetComponent<ReClick>().clicked)
        {
            Destroy(girlInstance);
        }
        else
        {
            girlInstance = Instantiate(girl, new Vector3(transform.position.x - transform.localScale.x / 2 - girl.transform.localScale.x / 2, transform.position.y - transform.localScale.y / 2 - girl.transform.localScale.y / 2, 0), Quaternion.identity, canvas);
            //girlInstance.transform.Rotate(new Vector3(0, 0, transform.eulerAngles.z));
            girlInstance.GetComponent<MyChair>().chair = gameObject;
        }
        
    }

}