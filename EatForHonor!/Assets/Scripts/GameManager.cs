using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using System;
using System.Text.RegularExpressions;


public class GameManager : MonoBehaviour
{

	public static GameManager instance = null;

	//Variables encargadas de los cambios de etapa
	public string stage = "MainMenu"; 
	public string previewStage;
    public int numStage;

	//Variables encargadas de los puntajes y condiciones de victoria/derrota
	public int score = 0;
	public int honor = 0;
	public int deshonor = 0;

	//Objeto encargado de la informacion de las etapas
	public GameObject Info;

    //Botones
    public Transform MainMenu;
    public Transform TryAgain;
    public Transform NextStage;
    private Transform ns;
    private Transform ta;
    private Transform mm;

    //Canvas
    public Transform canv;
    

	//Variables para la generacion de personas en los distintos niveles
	public GameObject[] TiposPersonas;
    public int[] PersonasPermitidasEtapa1 = new int[4];
    public int[] PersonasPermitidasEtapa2 = new int[4];
    public int[] PersonasPermitidasEtapa3 = new int[4];
	public int[] PersonasPermitidasEtapa4 = new int[4];
	public int[] PersonasPermitidasEtapa5 = new int[4];
	public int[] PersonasPermitidasEtapa6 = new int[4];
    public int[] PersonasPermitidas = new int[4];

    //Controlar que haya solo un ShowPersonOptionsAlavez
    public int PersonTaken = -1;
	public string SillaUsada = "";

	//Variables para la generacion de olas
	public bool HasWaves = true;

	void Awake()
	{
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy(gameObject);
        //TurnOffButtons ();
        DontDestroyOnLoad(gameObject);
		InitGame();
	}

	//Initializes the game for each level.
	void InitGame()
	{
		SceneManager.LoadScene ("MainMenu");
		Info.gameObject.SetActive(false);
	}

	//Update is called every frame.
	void Update()
	{
		if (stage.Contains("Stage") && !HasWaves) 
		{
			//int stageNumber = Int32.Parse(Regex.Match(stage, @"\d+").Value);
			bool victory = Victory (numStage);
			if (victory) {
                //previewStage = stage;
                numStage += 1;
                stage = "Next";
                SceneManager.LoadScene("Next");
                //ns = Instantiate(NextStage, new Vector3(-433.31f, -310.66f, 0), Quaternion.identity, canv);
                //NextStage.GetComponent<Button>().enabled = true;
                //GameObject.Find ("btnWinner").GetComponent<UnityEngine.UI.Button> ().enabled = true;
            } else {
                //previewStage = stage;
                stage = "Perdiste";
                SceneManager.LoadScene("Perdiste");
                //ta = Instantiate(TryAgain, new Vector3(-433.31f, -309.36f, 0), Quaternion.identity, canv);
                //ns = Instantiate(NextStage, new Vector3(-433.31f, -312.66f, 0), Quaternion.identity, canv);
                //TryAgain.GetComponent<Button>().enabled = true;
                //MainMenu.GetComponent<Button>().enabled = true;
                //GameObject.Find ("btnLoser").GetComponent<UnityEngine.UI.Button> ().enabled = true;
            }
		}
	}

	//Decide si hay victoria, y setea los botones asociados a la visctoria y a la derrota
	private bool Victory(int stage)
	{
		//transform.Find("btnsLoser").GetComponent<ClickActs>().Linkto = previewStage;
		if (stage == 1) 
		{
			//transform.Find("btnsWinner").GetComponent<ClickActs>().Linkto = "InterStage1";
			return honor > deshonor;
		}
		else if (stage == 2) 
		{
			//transform.Find("btnsWinner").GetComponent<ClickActs>().Linkto = "InterStage2";
			return 2 * deshonor < honor;	
		}
		else if (stage == 3) 
		{
			//transform.Find("btnsWinner").GetComponent<ClickActs>().Linkto = "InterStage3";
			return deshonor == 0;
		}
		else 
		{
			return false;
		}
	}

	//public void TurnOnButtons()
	//{
	//	GameObject.Find ("btnLoser").GetComponent<UnityEngine.UI.Button> ().enabled = true;
	//	GameObject.Find ("btnWinner").GetComponent<UnityEngine.UI.Button> ().enabled = true;
	//}

	//public void TurnOffButtons()
	//{
	//	GameObject.Find ("btnLoser").GetComponent<UnityEngine.UI.Button> ().enabled = false;
	//	GameObject.Find ("btnWinner").GetComponent<UnityEngine.UI.Button> ().enabled = false;
	//	GameObject.Find ("btnLoser").SetActive (false);
	//	GameObject.Find ("btnWinner").SetActive (false);
	//}
}