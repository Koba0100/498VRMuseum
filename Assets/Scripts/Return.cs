using UnityEngine;
using System.Collections;

public class Return : MonoBehaviour
{
	void Update ()
	{
		if (Input.GetKeyDown(KeyCode.R))
			Application.LoadLevel("Lobby");
	}
}
