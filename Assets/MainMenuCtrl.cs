using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuCtrl : MonoBehaviour {

	public Button lvl02btn, lvl03btn, lvl04btn, lvl05btn;
	int lvlPass;

	// Use this for initialization
	void Start () {
		lvlPass = PlayerPrefs.GetInt ("LevelPassed");
		lvl02btn.interactable = false;
		lvl03btn.interactable = false;
		lvl04btn.interactable = false;
		lvl05btn.interactable = false;

		switch (lvlPass)
		{
			case 1:
			lvl02btn.interactable = true;
			break;

			case 2:
			lvl02btn.interactable = true;
			lvl03btn.interactable = true;
			break;

			case 3:
			lvl02btn.interactable = true;
			lvl03btn.interactable = true;
			lvl04btn.interactable = true;
			break;

			case 4:
			lvl02btn.interactable = true;
			lvl03btn.interactable = true;
			lvl04btn.interactable = true;
			lvl05btn.interactable = true;
			break;
		}
	}
	
	public void levelToLoad (int level)
	{
		SceneManager.LoadScene(level);
	}

	public void resetPlayerPrefers()
	{
		lvl02btn.interactable = false;
		lvl03btn.interactable = false;
		lvl04btn.interactable = false;
		lvl05btn.interactable = false;
		PlayerPrefs.DeleteAll();
	}
}
