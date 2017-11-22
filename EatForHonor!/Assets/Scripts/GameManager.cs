using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{

	public static GameManager instance = null;

	//Variables encargadas de los cambios de etapa
	public string stage = "MainMenu"; 
	public string previewStage;

	//Variables encargadas de los puntajes y condiciones de victoria/derrota
	public int score = 0;
	public int honor = 0;
	public int deshonor = 0;
	public int checkin_if_sublimeworks = 10;

	//Variables para la generacion de personas en los distintos niveles
	public GameObject[] TiposPersonas;
	public int[] PersonasPermitidas = new int[4];

	//Objeto encargado de la informacion de las etapas
	public GameObject Info;

	//Controlar que haya solo un ShowPersonOptionsAlavez
	public int PersonTaken = -1;
	public string SillaUsada = "";

	//Awake is always called before any Start functions
	void Awake()
	{
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy(gameObject);

		DontDestroyOnLoad(gameObject);
		//menuController = GetComponent<MenuCrontoller>();
		InitGame();
	}

	//Initializes the game for each level.
	void InitGame()
	{
		SceneManager.LoadScene (stage);
		Info.gameObject.SetActive(false);

		//Info.GetComponent<Renderer> ().enabled = false;
		//menuController.LoadScene(stage);
	}

	//Update is called every frame.
	void Update()
	{

	}

}