using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class spiky_death : MonoBehaviour 
{

public Vector2 kbHeight;
private GameObject player;
private player_universal player_universal;
 
    void Start()
    {
    	player = GameObject.Find("zero");
    }
 
    IEnumerator OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.gameObject.name == "zero")
        {
           	player.GetComponent<player_universal>().Damage(5);
            yield return new WaitForSeconds(2);
            SceneManager.LoadScene("citynight");
        }
    }
}
