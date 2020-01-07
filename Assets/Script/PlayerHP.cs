using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour {

	public int health;
	public Animator animator;
	public GameObject dieMenuUI;

	void Start()
	{
		//rb = GetComponent<Rigidbody>();
	}
	// Use this for initialization
	
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
		
			Destroy(gameObject, 1.6f);
			Invoke("Pause", 1.4f);
			this.GetComponent<PlayerMovement>().enabled = false;
			
	}

	void Pause()
	{
		dieMenuUI.SetActive(true);

		Time.timeScale = 0f;
		//animator.enabled = false;
	}
}