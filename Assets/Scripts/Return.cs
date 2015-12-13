using UnityEngine;
using System.Collections;

public class Return : MonoBehaviour
{
	// This script has become a bit of a potpurri of madness. It all works though.
	// Kinda.

	void Update ()
	{
		if (Input.GetKeyDown(KeyCode.R))
			Application.LoadLevel("Lobby");


		// Test turning
		if (Input.GetKeyDown (KeyCode.LeftArrow))
			transform.localEulerAngles = new Vector3 (transform.localEulerAngles.x, transform.localEulerAngles.y - 30, transform.localEulerAngles.z);
		if (Input.GetKeyDown (KeyCode.RightArrow))
			transform.localEulerAngles = new Vector3 (transform.localEulerAngles.x, transform.localEulerAngles.y + 30, transform.localEulerAngles.z);

		// Dr. Yershova asked for discrete forward and backwards movement, so here's that. Need some proactive checks so you can't fall through the world.
		// It doesn't work very well. Also, carpal tunnel.
		// Forward / Backward
		LayerMask level = 1 << LayerMask.NameToLayer ("Default");
		Vector3 move = transform.forward;
		move.y = 2;
		bool hit = Physics.Raycast (transform.position + (0.25f * transform.forward), transform.position + (2f * move), level);
		bool backHit = Physics.Raycast (transform.position - (0.25f * transform.forward), transform.position - (2f * move), level);
		if (Input.GetKeyDown (KeyCode.UpArrow) && !hit) 
		{
			transform.position = transform.position + transform.forward;
			transform.position = new Vector3(transform.position.x, transform.position.y + 0.4f, transform.position.z);
		}

		if (Input.GetKeyDown (KeyCode.DownArrow) && !backHit) 
		{
			transform.position = transform.position - transform.forward;
		}

		// Just-In-Case position reset
		if (transform.position.y < -20)
			Application.LoadLevel (Application.loadedLevel);

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
