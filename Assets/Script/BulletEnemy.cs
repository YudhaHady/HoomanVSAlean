using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemy : MonoBehaviour {

	public float moveSpeed = 5f;
	public int damage = 10;

	public Rigidbody2D rb;
	public GameObject impactEffect;

	PlayerMovement target;
	Vector2 moveDirection;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		target = GameObject.FindObjectOfType<PlayerMovement>();
		moveDirection = (target.transform.position - transform.position).normalized * moveSpeed;
		rb.velocity = new Vector2 (moveDirection.x, moveDirection.y);
		Destroy (gameObject, 5f);

	}

	void OnTriggerEnter2D (Collider2D hitInfo)
	{
		PlayerHP Player = hitInfo.GetComponent<PlayerHP>();
		if (Player != null)
		{
			Player.TakeDamage(damage);
			HealthBarPlayer.health -= 10f;

		}
			Instantiate(impactEffect, transform.position, transform.rotation);
			Destroy (gameObject);

		
	}

}
