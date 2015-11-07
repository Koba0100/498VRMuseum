using UnityEngine;
using System.Collections;

public class Teleporter : MonoBehaviour 
{
	public string levelToLoad;
	public LayerMask playerLayer;
	
	void Update () 
	{
		if (Physics.CheckSphere(transform.position, 1.5f, playerLayer))
		{
			Application.LoadLevel(levelToLoad);
		}
	}
}
