using UnityEngine;
using System.Collections;

public class Spin : MonoBehaviour
{
	public float spinSpeed = 2f;

	void Update ()
	{
		transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y + spinSpeed, transform.localEulerAngles.z);
	}
}
