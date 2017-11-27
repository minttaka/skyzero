using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_movement : MonoBehaviour 
{
	public float smoothTimeY;
	public float smoothTimeX;
	public GameObject player;
	public bool bounds;
	public Vector3 minCameraPos;
	public Vector3 maxCameraPos;

	private Vector2 velocity;
	
	void Start () 
	{

	}
	
	
	void LateUpdate () 
	{
		float posX = Mathf.SmoothDamp(transform.position.x, player.transform.position.x, ref velocity.x, smoothTimeX);
		float posY = Mathf.SmoothDamp(transform.position.y, player.transform.position.y, ref velocity.y, smoothTimeY);

		transform.position = new Vector3(posX, posY, transform.position.z);

		if (bounds == true)
		{
			transform.position = new Vector3(Mathf.Clamp(transform.position.x, minCameraPos.x, maxCameraPos.x), 
				Mathf.Clamp(transform.position.y, minCameraPos.y, maxCameraPos.y), 
				Mathf.Clamp(transform.position.z, minCameraPos.z, maxCameraPos.z));
		};
 	}
}
