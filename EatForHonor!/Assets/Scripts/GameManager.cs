using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{

	public static GameManager instance = null;
	public string stage = "MainMenu"; 
	public string previewStage;
	public int score = 0;
	public int checkin_if_sublimeworks = 10;

	//Variables para la generacion de personas en los distintos niveles
	public GameObject[] TiposPersonas;
	public int[] PersonasPermitidas = new int[4];
	//Controlar que haya solo un ShowPersonOptionsAlavez
	public bool ShowingPersons;
	public bool CanShowPersons = true;
	public int PersonTaken = -1;

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
		//menuController.LoadScene(stage);
	}

	//Update is called every frame.
	void Update()
	{

	}

}