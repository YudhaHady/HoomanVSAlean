using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthBar : MonoBehaviour {
	public float playerhealth;
	// public GameObject enemyDeathFX;
	public Slider enemyHealthBar;
	float currhealth;
	//public bool drops;
	//public GameObject thedrop;
	//public AudioClip deathKnell;

	// Use this for initialization
	void Start () {
		currhealth = playerhealth;
		enemyHealthBar.maxValue = currhealth;
		enemyHealthBar.value = currhealth;
	}

	// Update is called once per frame
	void Update () {

	}
	public void DiDor(float hitInfo){
		currhealth = currhealth - hitInfo;
		enemyHealthBar.value = currhealth;
		if(currhealth<=0){
			//makeDead();
		}
	}
	public void makeDead(){
		//AudioSource.PlayClipAtPoint(deathKnell, transform.position);
		//Destroy(gameObject);
		// Instantiate (enemyDeathFX,transform.position, transform.rotation);
		 //if(drops) Instantiate(thedrop,transform.position, transform.rotation);

	}
}
