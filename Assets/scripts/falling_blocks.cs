using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class falling_blocks : MonoBehaviour {

	public Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D coll)
	{
		if(coll.gameObject.name == "zero")
		{
			StartCoroutine(Fall());
		}
	}

	IEnumerator Fall()
	{
		yield return new WaitForSeconds(3/4);
		rb.isKinematic = false;
		GetComponent<Collider2D>().isTrigger = true;
		yield return 0;
	}
}
