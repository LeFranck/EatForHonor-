using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;


public class ClickActs : MonoBehaviour
{
	//Lista de botones con el mismo comportamiento en la escena
    public Button[] botones;
    public string Linkto;

    void Start()
    {
		for(int i = 0; i < botones.Length; i++)
		{
			Button btn = botones[i].GetComponent<Button>();
			if (btn.name != "BtnVolver") {
				btn.onClick.AddListener (TaskOnClick);
			} else {
				btn.onClick.AddListener (VolverOnClick);
			}
		}
    }

    void TaskOnClick()
    {
		GameManager.instance.previewStage = GameManager.instance.stage;
		GameManager.instance.stage = Linkto;
		SceneManager.LoadScene (Linkto);
    }

	void VolverOnClick()
	{
		string aux = GameManager.instance.previewStage;
		GameManager.instance.previewStage = GameManager.instance.stage;
		GameManager.instance.stage = aux;
		SceneManager.LoadScene (aux);
	}
}