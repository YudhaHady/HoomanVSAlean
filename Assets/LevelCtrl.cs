using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelCtrl : MonoBehaviour {

	public static LevelCtrl instance = null;
	public GameObject pauseMenuUI;
	int sceneIndex, levelPassed;

	// Use this for initialization
	void Start () {
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy (gameObject);

		pauseMenuUI.SetActive(false);

		sceneIndex = SceneManager.GetActiveScene().buildIndex;
		levelPassed = PlayerPrefs.GetInt ("LevelPassed");
	}
	
	public void youWin()
	{
		if (sceneIndex == 5)
		{
			Invoke ("loadMainMenu", 1f);
		}
		else
		{
			if(levelPassed < sceneIndex)
				PlayerPrefs.SetInt("LevelPassed", sceneIndex);
			
			pauseMenuUI.SetActive(true);
			Invoke ("loadNextLevel", 1f);
		}
	}

	public void youLose()
	{

	}

	void loadNextLevel()
	{
		SceneManager.LoadScene(sceneIndex + 1);
	}

	void loadMainMenu()
	{
		SceneManager.LoadScene ("Level");
	}
}
