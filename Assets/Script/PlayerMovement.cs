using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour {

	public CharacterController2D controller;
	public Animator animator;
	public float runSpeed = 40f;

	float horizontalMove = 0f;
	bool jump = false;
	bool shoot = false;

	// Update is called once per frame
	void Update () {
		horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

		animator.SetFloat("Counter", Mathf.Abs(horizontalMove));

		if (Input.GetButtonDown("Jump"))
		{
			jump = true;
			shoot = false;
			animator.SetBool("Jumping", true); 
			this.GetComponent<Weapon>().enabled = false;
		}

		if (Input.GetButtonDown("Fire1"))
		{
			shoot = true;
			animator.SetBool("Shoot", true);  
		}else if (Input.GetButtonUp("Fire1"))
		{
			shoot = false;
			animator.SetBool("Shoot", false); 
		}

		
	}


	public void OnLanding()
	{
		animator.SetBool("Jumping", false);
		this.GetComponent<Weapon>().enabled = true;
	}

	public void OnShoot (bool Shoot)
	{
		animator.SetBool("Shoot", true);

	}

	void FixedUpdate()
	{
		controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
		jump = false;
	}
}
