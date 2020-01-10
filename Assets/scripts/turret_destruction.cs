using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turret_destruction : MonoBehaviour {

	 

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void OnCollisionEnter2D(Collision2D coll)
	{
		if(coll.gameObject.name == "zero")
		{
			GetComponent<Collider2D>().isTrigger = true;
		}
	}
}
