using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoting : MonoBehaviour {

	[SerializeField]
	public Transform firePoint;
	public GameObject bullet;
	public Animator animator;
	public float fireRate = 5f;
	float nextFire;
	float waitTime;
	// Use this for initialization
	void Start () {
		//fireRate = 5f;
		nextFire = Time.time;
		
	}
	
	// Update is called once per frame
	void Update () {
		CheckIfTimeToFire ();
	}

	void CheckIfTimeToFire()
	{
		if (Time.time > nextFire) {
			Instantiate(bullet, firePoint.position, firePoint.rotation);
			nextFire = Time.time + fireRate;
			}
		
	}





}
