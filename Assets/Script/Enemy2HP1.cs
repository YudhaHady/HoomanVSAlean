using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2HP : MonoBehaviour {

	public int health = 500;
	public Animator animator;

	public static bool GameIsPaused = false;

	public GameObject pauseMenuUI;

	//private Transform bar;

	//public GameObject deathEffect;
	//bool die = false;

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
		//Instantiate(deathEffect, transform.position, Quaternion.identity);
		if(health==0)
		{
			Destroy(gameObject, 1.8f);
		}
		else
		{
		Invoke("Pause", 1.7f);
		}
	}

	void Pause()
	{
		pauseMenuUI.SetActive(true);
		Time.timeScale = 0f;
		animator.enabled = false;
	}

	/*private void Start()
	{
		bar = transform("Bar")
		
	}*/

}
