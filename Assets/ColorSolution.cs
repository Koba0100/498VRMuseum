using UnityEngine;
using System.Collections;
//for text
using UnityEngine.UI;

public class ColorSolution : MonoBehaviour {

	private GameObject intermSol;
	private MeshRenderer sol;
	private GameObject intermText;
	private Text textSol;
	private bool seeSol = false;
	
	// Use this for initialization
	void Start () {
		intermSol = GameObject.Find ("SolutionRectangle (1)");
		sol = intermSol.GetComponent<MeshRenderer>();
		sol.enabled = false;
		
		intermText = GameObject.Find ("Color Const Text");
		textSol = intermText.GetComponent<Text>();
		textSol.text = "[color]000[wave]Which of the small squares has the lightest color? Press the Right Shift Key for the  answer.[wave][color]";
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.RightShift) && seeSol == false) {
			seeSol = true;
			sol.enabled = true;
			textSol.text = "[color]000[wave]The small squares have the same color![wave][color]";
			
			StartCoroutine(Example());
		}
	}
	
	IEnumerator Example() {
		yield return new WaitForSeconds(15);
		sol.enabled = false;
		textSol.text = "[color]000[wave]Which of the small squares has the lightest color? Press the Right Shift Key for the  answer.[wave][color]";
		seeSol = false;
	}
}
