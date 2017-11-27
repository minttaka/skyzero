using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ship_trigger : MonoBehaviour 
{

	private enemy_ship enemy_ship;
	private GameObject enemyShip;

	// Use this for initialization
	void Start () 
	{
		enemyShip = GameObject.Find("enemy_ship");
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void OnTriggerStay2D(Collider2D coll)
	{
		if(coll.gameObject.name == "zero")
		{
			enemyShip.GetComponent<enemy_ship>().Attack();	
		}
	}
}
