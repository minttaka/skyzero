using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_ship : MonoBehaviour 
{

	public float bombTimer;
	public float shootInterval;
	public Transform shootPoint;
	public float bombSpeed = 100f;
	public GameObject bomb;
	public Transform target;
 	public float min = 1f;
	public float max = 10f;
	public int maxHealth = 10;
	public int curHealth;
	private bool isDead = false;

    void Start () 
    {
       
        min = transform.position.x;
        max = transform.position.x + 14;

        curHealth = maxHealth;
    }
   
    void Update () 
    {
    	transform.position = new Vector3(Mathf.PingPong(Time.time * 2, max - min) + min, transform.position.y, transform.position.z);
    	
    	if(curHealth > maxHealth)
    	{
        	curHealth = maxHealth;
    	}
      
    	if(curHealth <= 0)
    	{
      		Die();
    	}
 	}

  	void Die()
  	{
		isDead = true;

	if (curHealth < 0) 
      {
        curHealth = 0;
      }
      
      GetComponent<Rigidbody2D>().isKinematic = false;
      GetComponent<Collider2D>().isTrigger = true;
  	}

  	public void Damage(int dmg)
  	{
    	curHealth -= dmg;
  	}

	public void Attack()
	{	
		if (!isDead) {
			bombTimer += Time.deltaTime;
			
			if (bombTimer >= shootInterval) {
				Vector2 direction = target.transform.position - transform.position;
				direction.Normalize ();
				GameObject bombClone;
				bombClone = Instantiate (bomb, shootPoint.transform.position, shootPoint.transform.rotation) as GameObject;
				bombClone.GetComponent<Rigidbody2D> ().velocity = direction * bombSpeed;
				bombTimer = 0;
			}
		}
	}
}