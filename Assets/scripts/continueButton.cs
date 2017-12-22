using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class continueButton : MonoBehaviour {

	public void LoadByIndex(int index){
		SceneManager.LoadScene(index);
	}
}
