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
			transform.localEulerAngles = new Vector3 (transform.localEulerAngles.x, transform.localEulerAngles.y - 20, transform.localEulerAngles.z);
		if (Input.GetKeyDown (KeyCode.RightArrow))
			transform.localEulerAngles = new Vector3 (transform.localEulerAngles.x, transform.localEulerAngles.y + 20, transform.localEulerAngles.z);
	}
}
