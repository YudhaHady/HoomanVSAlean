using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoting : MonoBehaviour {

	[SerializeField]
	public Transform firePoint;
	public GameObject bullet;
	public Animator animator;
	public float fireRate = 5f;
	public float shooting = 0f;
	float nextFire;
	float waitTime;
	// Use this for initialization
	void Start () {
		nextFire = Time.time;
		
	}
	
	// Update is called once per frame
	void Update () {
		CheckIfTimeToFire ();
		//yield return new WaitForSeconds(4);
	}

	void CheckIfTimeToFire()
	{
		if (Time.time > nextFire) 
			{
				animator.SetFloat("counter", Mathf.Abs(shooting));
				//animator.SetBool("Attack", true);  
				Instantiate(bullet, firePoint.position, firePoint.rotation);
				nextFire = Time.time + fireRate;
			}
		
	}





}
