using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player_universal : MonoBehaviour 
{

public Vector2 jumpHeight;
public Rigidbody2D rb;
public float speed = 1.0f;
public bool animSpeed = false;
public bool movingRight = false;
public bool movingLeft = false;
public int curHealth;
public int maxHealth = 5;
public float laserTimer;
public float laserSpeed;
public GameObject laser;
public float shootInterval;
public GameObject target;
public Transform shootPoint;

private bool isGrounded = true;
private float nextJump;
private Animator anim;

	
	// Use this for initialization
	void Start () 
	{
		rb = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();

    curHealth = maxHealth;
	}
	
	// Update is called once per frame
	void Update ()
	{
		anim.SetBool("movingRight", movingRight);
		anim.SetBool("animSpeed", animSpeed);
  
        var move = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        transform.position += move * speed * Time.deltaTime;

		if(Input.GetKeyDown("w") && isGrounded && Time.time >= nextJump) 
        {
   			rb.AddForce(jumpHeight, ForceMode2D.Impulse);
   			nextJump = Time.time + 0.8f;
   		};
   		if(Input.GetAxis("Horizontal") == 0f)
   		{
   			animSpeed = false;
   			movingRight = false;
   		};
   		if(Input.GetAxis("Horizontal") < 0f)
   		{
   			animSpeed = true;
   			movingRight = false;
   		};
   		if(Input.GetAxis("Horizontal") > 0f)
   		{
   			animSpeed = true;
   			movingRight = true;
   		};
      if(Input.GetKey(KeyCode.LeftShift))
      {
        Attack();
      }
      
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
      if (curHealth < 0) 
      {
      curHealth = 0;
      }
      SceneManager.LoadScene("citynight");
  }

  public void Damage(int dmg)
  {
    curHealth -= dmg;
  }

  public void Attack()
  { 
    laserTimer += Time.deltaTime;
    if (laserTimer >= shootInterval)
    {
      Vector2 direction = (Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position));
      direction.Normalize();
      GameObject laserClone;
      laserClone = Instantiate(laser, shootPoint.transform.position, shootPoint.transform.rotation) as GameObject;
      laserClone.GetComponent<Rigidbody2D>().velocity = direction * laserSpeed;
      laserTimer = 0;
    }
  }

}