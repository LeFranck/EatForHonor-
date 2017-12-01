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
        GameManager.instance.Info.transform.Find("txtHonor").GetComponent<TextMesh>().text = "0";
        GameManager.instance.Info.transform.Find("txtDeshonor").GetComponent<TextMesh>().text = "0";
        //SceneManager.LoadScene("Stage2");
        if (GameManager.instance.numStage == 1)
        {
            for (int i = 0; i < GameManager.instance.PersonasPermitidas.Length; i++)
            {
                GameManager.instance.PersonasPermitidas[i] = GameManager.instance.PersonasPermitidasEtapa2[i];
            }
        }

        if (GameManager.instance.numStage == 2)
        {
            for (int i = 0; i < GameManager.instance.PersonasPermitidas.Length; i++)
            {
                GameManager.instance.PersonasPermitidas[i] = GameManager.instance.PersonasPermitidasEtapa2[i];
            }            
        }

        if (GameManager.instance.numStage == 3)
        {
            for (int i = 0; i < GameManager.instance.PersonasPermitidas.Length; i++)
            {
                GameManager.instance.PersonasPermitidas[i] = GameManager.instance.PersonasPermitidasEtapa2[i];
            }
        }

        if (GameManager.instance.numStage == 4)
        {
            for (int i = 0; i < GameManager.instance.PersonasPermitidas.Length; i++)
            {
                GameManager.instance.PersonasPermitidas[i] = GameManager.instance.PersonasPermitidasEtapa2[i];
            }
        }

        GameManager.instance.Info.transform.Find("txt1").GetComponent<TextMesh>().text = GameManager.instance.PersonasPermitidas[0] + "";
        GameManager.instance.Info.transform.Find("txt2").GetComponent<TextMesh>().text = GameManager.instance.PersonasPermitidas[1] + "";
        GameManager.instance.Info.transform.Find("txt3").GetComponent<TextMesh>().text = GameManager.instance.PersonasPermitidas[2] + "";
        GameManager.instance.Info.transform.Find("txt4").GetComponent<TextMesh>().text = GameManager.instance.PersonasPermitidas[3] + "";
        SceneManager.LoadScene("Stage" + GameManager.instance.numStage.ToString());
        GameManager.instance.stage = "Stage" + GameManager.instance.numStage.ToString();
        GameManager.instance.Info.gameObject.SetActive(true);
    }

    public void main()
    {
        Debug.Log("main");
        GameManager.instance.Info.gameObject.SetActive(false);
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
