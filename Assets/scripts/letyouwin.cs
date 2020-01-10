using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class letyouwin : MonoBehaviour {

	private GameObject enemyShip;

	// Use this for initialization
	void Start () {
		enemyShip = GameObject.Find("enemy_ship");
	}
	
	// Update is called once per frame
	void Update () {
		if(!enemyShip.GetComponent<Rigidbody2D>().isKinematic) {
			GetComponent<Collider2D>().isTrigger = true;
		};
	}
}
