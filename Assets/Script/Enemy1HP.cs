using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Enemy1HP : MonoBehaviour {

	public Button[] lvlButtons;
	public int nextSceneLoad;
	public int health = 200;
	public Animator animator;

	public GameObject pauseMenuUI;


	void Start()
	{
		nextSceneLoad = SceneManager.GetActiveScene().buildIndex + 1;
	}

	public void TakeDamage (int damage)
	{
		health -= damage;

		if(health <= 0)
		{
			animator.SetBool("Die", true);
			Die();
		}
	}

	void Die()
	{
		if(health==0)
		
			Destroy(gameObject, 1.8f);
			Invoke("Pause", 1.7f);
			
	}

	void Pause()
	{
		pauseMenuUI.SetActive(true);
		Time.timeScale = 0f;
	}

	public void OnloadNextLevel()
	{
		SceneManager.LoadScene(nextSceneLoad);
		Time.timeScale = 1f;

		if(nextSceneLoad > PlayerPrefs.GetInt("levelAt"))
		{
			
			PlayerPrefs.SetInt("levelAt", nextSceneLoad);
			for (int i = 0; i < lvlButtons.Length; i++)
		{
			
			lvlButtons[i].interactable = true;
		}
			
		}
	}


}
