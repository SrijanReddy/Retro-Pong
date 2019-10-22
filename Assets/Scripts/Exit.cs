using UnityEngine;
using System.Collections;

public class Exit : MonoBehaviour
{
	void OnMouseDown()
	{
		transform.localScale *= 1.1F;
	}

	void OnMouseUp()
	{
		Application.Quit();
	}
}