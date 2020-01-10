using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plusLife : MonoBehaviour {

	private player_universal player_universal;
	private GameObject player;
	private int curHealth;

	void OnTriggerEnter2D(Collider2D coll)
	{
		if (coll.gameObject.name == "zero")
		{
			player = GameObject.Find("zero");
			player.GetComponent<player_universal>().curHealth = 5;
			Destroy(gameObject);
		}
	}
}
