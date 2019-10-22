using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour
{
	public float paddleSpeed = 1;
	public Vector3 playerPos;

	void Update()
	{
		float yPos = transform.position.y + (Input.GetAxis("Vertical") * paddleSpeed);
		playerPos = new Vector3(-20, Mathf.Clamp(yPos, -12.5F, 12.5F), 0);
		transform.position = playerPos;
	}
}
