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
			//if (btn.name == "btnLoser" || btn.name == "btnWinner") {
			//	btn.onClick.AddListener (TurnOffvictory);
			//}
		}
    }

    public void TaskOnClick()
	{
		GameManager.instance.previewStage = GameManager.instance.stage;
		GameManager.instance.stage = Linkto;
		SceneManager.LoadScene (Linkto);
		EnabledInfo (Linkto);
    }

	void VolverOnClick()
	{
		string aux = GameManager.instance.previewStage;
		GameManager.instance.previewStage = GameManager.instance.stage;
		GameManager.instance.stage = aux;
		SceneManager.LoadScene (aux);
		EnabledInfo (aux);
	}

	//void TurnOffvictory()
	//{
	//	GameManager.instance.TurnOffButtons ();
	//}

	private void EnabledInfo(string nextStage){
		if (nextStage.Contains ("Stage")) {
			GameManager.instance.Info.gameObject.SetActive(true);
		}
	}

}