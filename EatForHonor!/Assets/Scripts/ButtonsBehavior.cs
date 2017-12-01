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
		if (GameManager.instance.numStage == 1) {
            SoundManager.instance.music.clip = SoundManager.instance.stage1Music;
            SoundManager.instance.music.Play();
            for (int i = 0; i < GameManager.instance.PersonasPermitidas.Length; i++) {
				GameManager.instance.PersonasPermitidas [i] = GameManager.instance.PersonasPermitidasEtapa1 [i];
			}
		} else if (GameManager.instance.numStage == 2) {
            SoundManager.instance.music.clip = SoundManager.instance.stage2Music;
            SoundManager.instance.music.Play();
            for (int i = 0; i < GameManager.instance.PersonasPermitidas.Length; i++) {
				GameManager.instance.PersonasPermitidas [i] = GameManager.instance.PersonasPermitidasEtapa2 [i];
			}            
		} else if (GameManager.instance.numStage == 3) {
            SoundManager.instance.music.clip = SoundManager.instance.stage3Music;
            SoundManager.instance.music.Play();
            for (int i = 0; i < GameManager.instance.PersonasPermitidas.Length; i++) {
				GameManager.instance.PersonasPermitidas [i] = GameManager.instance.PersonasPermitidasEtapa3 [i];
			}
		} else if (GameManager.instance.numStage == 4) {
            SoundManager.instance.music.clip = SoundManager.instance.stage4Music;
            SoundManager.instance.music.Play();
            for (int i = 0; i < GameManager.instance.PersonasPermitidas.Length; i++) {
				GameManager.instance.PersonasPermitidas [i] = GameManager.instance.PersonasPermitidasEtapa4 [i];
			}
		} else if (GameManager.instance.numStage == 5) {
			for (int i = 0; i < GameManager.instance.PersonasPermitidas.Length; i++) {
				GameManager.instance.PersonasPermitidas [i] = GameManager.instance.PersonasPermitidasEtapa5 [i];
			}
		} else if (GameManager.instance.numStage == 6) {
			for (int i = 0; i < GameManager.instance.PersonasPermitidas.Length; i++) {
				GameManager.instance.PersonasPermitidas [i] = GameManager.instance.PersonasPermitidasEtapa6 [i];
			}
		} else {
			Debug.Log("BERRU QLO");
		}

        GameManager.instance.Info.transform.Find("txt1").GetComponent<TextMesh>().text = GameManager.instance.PersonasPermitidas[0] + "";
        GameManager.instance.Info.transform.Find("txt2").GetComponent<TextMesh>().text = GameManager.instance.PersonasPermitidas[1] + "";
        GameManager.instance.Info.transform.Find("txt3").GetComponent<TextMesh>().text = GameManager.instance.PersonasPermitidas[2] + "";
		GameManager.instance.Info.transform.Find("txt4").GetComponent<TextMesh>().text = GameManager.instance.PersonasPermitidas[3] + "";
        SceneManager.LoadScene("Stage" + GameManager.instance.numStage.ToString());
        //SceneManager.LoadScene("Stage3");
        GameManager.instance.stage = "Stage" + GameManager.instance.numStage.ToString();
        GameManager.instance.Info.gameObject.SetActive(true);
    }

    public void main()
    {
        Debug.Log("main");
        GameManager.instance.Info.gameObject.SetActive(false);
        SceneManager.LoadScene("MainMenu");
        GameManager.instance.stage = "MainMenu";
        SoundManager.instance.music.clip = SoundManager.instance.mainMusic;
        SoundManager.instance.music.Play();
    }

    public void intro()
    {
        Debug.Log("intro");
        SceneManager.LoadScene("Introduccion");
        GameManager.instance.stage = "Introduccion";
        SoundManager.instance.music.clip = SoundManager.instance.stage1Music;
        SoundManager.instance.music.Play();
    }

    public void conf()
    {
        Debug.Log("conf");
        SceneManager.LoadScene("configuracion");
        GameManager.instance.stage = "configuracion";
    }

}
