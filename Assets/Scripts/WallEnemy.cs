using UnityEngine;
using System.Collections;

public class WallEnemy : MonoBehaviour 
{
	public float speed = 8;
	Vector3 targetPos;
	Vector3 playerPos;
	GameObject ballObj;

	void Update()
	{
		ballObj = GameObject.FindGameObjectWithTag("Ball");
		if(ballObj != null)
		{
			
		}
	}
}