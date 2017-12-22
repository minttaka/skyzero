using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gotoending : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D coll){
		if(coll.gameObject.name == "zero"){
			SceneManager.LoadScene("ending");
		}
	}
}
