using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GUImanager : MonoBehaviour {

	public void OnPlay()
	{
		Time.timeScale = 1f;
		SceneManager.LoadScene("Scenes/Level");
	}

	public void OnOption()
	{
		SceneManager.LoadScene("Option");
	}

	public void OnExit()
	{
		Debug.Log("Quit!");
		Application.Quit();
	} 

	public void OnBack()
	{
		SceneManager.LoadScene("Scenes/Main");
	}

	public void OnLevel1()
	{
		Time.timeScale = 1f;
		SceneManager.LoadScene("Scenes/Level1");
	}

	public void OnLevel2()
	{
		Time.timeScale = 1f;
		SceneManager.LoadScene("Scenes/Level2");
	} 

	public void OnLevel3()
	{
		Time.timeScale = 1f;
		SceneManager.LoadScene("Scenes/Level3");
	} 

	public void OnLevel4()
	{
		Time.timeScale = 1f;
		SceneManager.LoadScene("Scenes/Level4");
	} 

	public void OnLevel5()
	{
		Time.timeScale = 1f;
		SceneManager.LoadScene("Scenes/Level5");
	} 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
