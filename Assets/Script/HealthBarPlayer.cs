using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarPlayer : MonoBehaviour {

	Image healthBar;
	public float maxHealth;
	public static float health;
	
	// Use this for initialization
	void Start () {
		healthBar = GetComponent<Image>();
		health = maxHealth;
	}
	
	// Update is called once per frame
	void Update () {
		healthBar.fillAmount = health / maxHealth;
	}

	public void TakeDamage (int damage)
	{
		health -= damage;

		/*if(health <= 0)
		{
			animator.SetBool("Die", true);
			Die();
		}*/
	}
}