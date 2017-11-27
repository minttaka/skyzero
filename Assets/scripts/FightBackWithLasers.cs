using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightBackWithLasers : MonoBehaviour {

	private GameObject enemy;
	private enemy_ship enemy_ship;


	// Use this for initialization
	void Start () {
		enemy = GameObject.Find("enemy_ship");
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	IEnumerator OnTriggerEnter2D(Collider2D coll)
	{
		if (coll.gameObject.name == "enemy_ship")
		{
			enemy.GetComponent<enemy_ship>().Damage(1);
			Destroy(gameObject);
			yield return 0;
		}
		else
		{
			yield return new WaitForSeconds(3);
			Destroy(gameObject);
			yield return 0;
		}
	}
}
