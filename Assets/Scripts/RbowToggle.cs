using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class RbowToggle : MonoBehaviour 
{
	bool rBow = true;
	bool flag = true;
	Text[] textComps;


	// Use this for initialization
	void Start () 
	{
		textComps = GetComponentsInChildren<Text> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (flag != rBow) 
		{
			flag = rBow;
			if (rBow)
				for (int i = 0; i < textComps.Length; i++)
					textComps [i].text = "[wave][rbowwave]TTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT";
			else
				for (int i = 0; i < textComps.Length; i++)
					textComps [i].text = "[wave]TTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT";
		}

		if (Input.GetKeyDown (KeyCode.X))
			rBow = !rBow;
	}
}
