using UnityEngine;
using System.Collections;

public class Sphere : MonoBehaviour {
	Transform smove; 
	int c=0; 
	string var = "";
	float x, y,z=0.0f; 
	int[] flagx,flagy,flagz; 

	// Use this for initialization
	void Start () {
		flagx = new int[8];
		flagy = new int[8];
		flagz = new int[8];

	}
	
	// Update is called once per frame
	void Update () {
	
		int i=0; 
			smove = GameObject.Find ("Sphere (1)").GetComponent<Transform> (); 
			x = (-1.2f - (2.13f + 1.2f));
	 
			if (flagx[i] == 1)
				smove.Translate (-x * Time.deltaTime, z, z, Space.World);
			else 
				smove.Translate (x * Time.deltaTime, z, z, Space.World);

			if (smove.localPosition.x >= 2.13f)
				flagx[i] = 0;
			if (smove.localPosition.x <= x) 
				flagx[i] = 1; 


		i++;
			smove = GameObject.Find ("Sphere (2)").GetComponent<Transform> (); 
			x= (-1.2f-Mathf.Abs (1.88f+1.2f));
			y= (-3.08f-Mathf.Abs (-1.8066f+3.08f));
	
			if (flagx[i] == 1)
				smove.Translate (-x * Time.deltaTime, -y * Time.deltaTime, z, Space.World);
			else 
				smove.Translate (x * Time.deltaTime, y * Time.deltaTime, z, Space.World);
			
			if (smove.localPosition.x >= 1.88f)
				flagx[i] = 0;
			if (smove.localPosition.x <= x) 	
				flagx[i] = 1; 

		i++;
		smove = GameObject.Find ("Sphere (3)").GetComponent<Transform> (); 
		x= (-1.2f-Mathf.Abs (1.16f+1.2f));
		y= (-3.08f-Mathf.Abs (-.723f+3.08f));
		
		if (flagx[i] == 1)
			smove.Translate (-x * Time.deltaTime, -y * Time.deltaTime, z, Space.World);
		else 
			smove.Translate (x * Time.deltaTime, y * Time.deltaTime, z, Space.World);
		
		if (smove.localPosition.x >= 1.16f)
			flagx[i] = 0;
		if (smove.localPosition.x <= x) 	
			flagx[i] = 1; 

		i++;
		smove = GameObject.Find ("Sphere (4)").GetComponent<Transform> (); 
		x= (-1.2f-Mathf.Abs (.07f+1.2f));
		y= (-3.08f-Mathf.Abs (0f+3.08f));
		
		if (flagx[i] == 1)
			smove.Translate (-x * Time.deltaTime, -y * Time.deltaTime, z, Space.World);
		else 
			smove.Translate (x * Time.deltaTime, y * Time.deltaTime, z, Space.World);
		
		if (smove.localPosition.x >= .07f)
			flagx[i] = 0;
		if (smove.localPosition.x <= x) 	
			flagx[i] = 1; 

		i++;
		smove = GameObject.Find ("Sphere (5)").GetComponent<Transform> (); 
		y= (-3.08f-Mathf.Abs (.253f+3.08f));
		
		if (flagx[i] == 1)
			smove.Translate (z, -y * Time.deltaTime, z, Space.World);
		else 
			smove.Translate (z, y * Time.deltaTime, z, Space.World);
		
		if (smove.localPosition.y >= .253f)
			flagx[i] = 0;
		if (smove.localPosition.y <= y) 	
			flagx[i] = 1;

		i++;
		smove = GameObject.Find ("Sphere (6)").GetComponent<Transform> (); 
		x= (-1.2f+Mathf.Abs (-2.47f+1.2f));
		y= (-3.08f-Mathf.Abs (0f+3.08f));
		print (smove.localPosition.y);
		if (flagx[i] == 1)
			smove.Translate (-x * Time.deltaTime, -y * Time.deltaTime, z, Space.World);
		else 
			smove.Translate (x * Time.deltaTime, y * Time.deltaTime, z, Space.World);
		
		if (smove.localPosition.x <= -2.47f)
			flagx[i] = 0;
		if (smove.localPosition.x >= x ) 	
			flagx[i] = 1;

			
		

	



}
}
