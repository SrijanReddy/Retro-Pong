using UnityEngine;
using System.Collections;

public class MenuBall : MonoBehaviour 
{
	public float ballVelocity = 3000;

	public Rigidbody rb;

	void Awake()
	{
		rb = GetComponent<Rigidbody>();

		rb.AddForce(new Vector3(ballVelocity, ballVelocity, 0));
	}
}