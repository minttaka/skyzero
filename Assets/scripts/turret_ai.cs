using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turret_ai : MonoBehaviour {

	public GameObject bullet;
	public Transform target;
	public float bulletSpeed = 100;
	public float bulletTimer;
	public float shootInterval;
	public Transform shootPoint;

	private player_universal player_universal;
	
	void Start () 
	{

	}
	
	
	void Update () 
	{
		
	}

	void OnTriggerStay2D(Collider2D coll)
	{
		if(coll.gameObject.name == "zero")
		{
			Attack();
		}
	}

	public void Attack()
	{
		bulletTimer += Time.deltaTime;
		if (bulletTimer >= shootInterval)
		{
			Vector2 direction = target.transform.position - transform.position;
			direction.Normalize();
			GameObject bulletClone;
			bulletClone = Instantiate(bullet, shootPoint.transform.position, shootPoint.transform.rotation) as GameObject;
			bulletClone.GetComponent<Rigidbody2D>().velocity = direction * bulletSpeed;
			bulletTimer = 0;
		}
	}
}
