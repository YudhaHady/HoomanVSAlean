using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelection : MonoBehaviour {

	public Button[] lvlButtons;
	// Use this for initialization
	void Start () {
		int levelAt = PlayerPrefs.GetInt("LavelAt", 2);

		for (int i = 0; i < lvlButtons.Length; i++)
		{
			if(i + 2 > levelAt)
			lvlButtons[i].interactable = false;
		}
	}

	/*public void PlayLevel(int level)
	{
		SceneManager.LoadScene(Level);
	}*/

	public void resetPlayerPrefers()
	{
		PlayerPrefs.DeleteAll();
	}
	
	
}
