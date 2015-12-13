using UnityEngine;
using System.Collections;

public class Return : MonoBehaviour
{
	// This script has become a bit of a potpurri of madness. It all works though.
	// Kinda.

	float moveTimer = 0f;
	float moveReset = 0.33f;

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
		LayerMask level = 1 << LayerMask.NameToLayer ("Default");	// Get layer of level.
		Vector3 move = transform.forward;	// Get the move direction unit vector.
		move.y = 2;		// push it up a bit so slopes still work.
		bool hit = Physics.Raycast (transform.position + (0.05f * transform.forward), transform.position + (2f * move), level);	// Check front hit
		bool backHit = Physics.Raycast (transform.position - (0.05f * transform.forward), transform.position - (2f * move), level);	// Check rear hit
		if (Input.GetKey (KeyCode.UpArrow) && !hit && moveTimer == 0f) 
		{
			moveTimer = 0.01f;
			transform.position = transform.position + transform.forward;
			transform.position = new Vector3(transform.position.x, transform.position.y + 0.4f, transform.position.z);	// Add a tiny amount of height so slopes still work.
		}

		if (Input.GetKey (KeyCode.DownArrow) && !backHit && moveTimer == 0f) 
		{
			moveTimer = 0.01f;
			transform.position = transform.position - transform.forward;
		}

		if (moveTimer > moveReset)
			moveTimer = 0f;
		else if (moveTimer >= 0.01f)
			moveTimer += Time.deltaTime;

		// Just-In-Case position reset
		if (transform.position.y < -20)
			Application.LoadLevel (Application.loadedLevel);

		// 360 Controller code

		float x=1* Input.GetAxis ("Horizontal");
		transform.Rotate (0, x, 0);

		float y = 1 * Input.GetAxis ("Vertical");
		Vector3 newPos = transform.position + (0.1f * y) * transform.forward;
		transform.position = newPos;


		// Mouse left click and right click controls
		if (Input.GetMouseButtonDown(0))
			transform.localEulerAngles = new Vector3 (transform.localEulerAngles.x, transform.localEulerAngles.y - 30, transform.localEulerAngles.z);
		if (Input.GetMouseButtonDown(1))
			transform.localEulerAngles = new Vector3 (transform.localEulerAngles.x, transform.localEulerAngles.y + 30, transform.localEulerAngles.z);


	}
}
