using UnityEngine;
using System.Collections;

public class Return : MonoBehaviour
{
	void Update ()
	{
		if (Input.GetKeyDown(KeyCode.R))
			Application.LoadLevel("Lobby");


		// Test turning
		if (Input.GetKeyDown (KeyCode.LeftArrow))
			transform.localEulerAngles = new Vector3 (transform.localEulerAngles.x, transform.localEulerAngles.y - 30, transform.localEulerAngles.z);
		if (Input.GetKeyDown (KeyCode.RightArrow))
			transform.localEulerAngles = new Vector3 (transform.localEulerAngles.x, transform.localEulerAngles.y + 30, transform.localEulerAngles.z);

		// 360 Controller code
		/*
		float x=1* Input.GetAxis ("Horizontal");
		transform.Rotate (0, x, 0);
		*/

		// Mouse left click and right click controls
		if (Input.GetMouseButtonDown(0))
			transform.localEulerAngles = new Vector3 (transform.localEulerAngles.x, transform.localEulerAngles.y - 30, transform.localEulerAngles.z);
		if (Input.GetMouseButtonDown(1))
			transform.localEulerAngles = new Vector3 (transform.localEulerAngles.x, transform.localEulerAngles.y + 30, transform.localEulerAngles.z);


	}
}
