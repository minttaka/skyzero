using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyThemWithLasers : MonoBehaviour {

	private GameObject player;
	private player_universal player_universal;


	// Use this for initialization
	void Start () {
		player = GameObject.Find("zero");
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	IEnumerator OnTriggerEnter2D(Collider2D coll)
	{
		if (coll.gameObject.name == "zero")
		{
			player.GetComponent<player_universal>().Damage(1);
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
