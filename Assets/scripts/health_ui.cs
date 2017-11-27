using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class health_ui : MonoBehaviour {

	public Sprite[] heartSprites;
	public Image heartUI;
	private player_universal playerScript;

	// Use this for initialization
	void Start () 
	{
		playerScript = GameObject.Find("zero").GetComponent<player_universal>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		heartUI.sprite = heartSprites[playerScript.curHealth];
	}
}
