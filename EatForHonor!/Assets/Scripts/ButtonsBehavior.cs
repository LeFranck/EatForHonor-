using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsBehavior : MonoBehaviour {

    public string to;
    //public string next;

    // Use this for initialization
    void Start() {
        to = "Stage" + GameManager.instance.numStage.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Do()
    {
        Debug.Log(to);
        GameManager.instance.HasWaves = true;
        //SceneManager.LoadScene("Stage2");
        SceneManager.LoadScene("Stage" + GameManager.instance.numStage.ToString());
        GameManager.instance.stage = "Stage" + GameManager.instance.numStage.ToString();
        GameManager.instance.Info.gameObject.SetActive(true);
    }

    public void main()
    {
        Debug.Log("main");
        SceneManager.LoadScene("MainMenu");
        GameManager.instance.stage = "MainMenu";
    }

    public void intro()
    {
        Debug.Log("intro");
        SceneManager.LoadScene("Introduccion");
        GameManager.instance.stage = "Introduccion";
    }

    public void conf()
    {
        Debug.Log("conf");
        SceneManager.LoadScene("configuracion");
        GameManager.instance.stage = "configuracion";
    }

}
