﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BltEnemy : MonoBehaviour {

	public float speed = 20f;
	public int damage = 40;
	public Rigidbody2D rb;
	public GameObject impactEffect;

	// Use this for initialization
	void Start () {
		rb.velocity = transform.right * speed;
		
	}
	
	void OnTriggerEnter2D (Collider2D hitInfo)
	{
		Enemy1HP enemy = hitInfo.GetComponent<Enemy1HP>();
		if (enemy != null)
		{
			enemy.TakeDamage(damage);
		}

		Instantiate(impactEffect, transform.position, transform.rotation);
		Destroy(gameObject);
	}
	
}
