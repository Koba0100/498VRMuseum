using UnityEngine;
using System.Collections;
//for text
using UnityEngine.UI;

public class IllusionSolution : MonoBehaviour {

	private GameObject intermSol;
	private MeshRenderer sol;
	private GameObject intermText;
	private Text textSol;
	private bool seeSol = false;

	// Use this for initialization
	void Start () {
		intermSol = GameObject.Find ("SolutionRectangle");
		sol = intermSol.GetComponent<MeshRenderer>();
		sol.enabled = false;

		intermText = GameObject.Find ("Size Const Text");
		textSol = intermText.GetComponent<Text>();
		textSol.text = "[color]000[wave]Which orange circle is the largest? Press the Enter Key for the answer.[wave][color]";
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Return) && seeSol == false) {
			seeSol = true;
			sol.enabled = true;
			textSol.text = "[color]000[wave]The circles are the same size![wave][color]";

			StartCoroutine(Example());
		}
	}

	IEnumerator Example() {
		yield return new WaitForSeconds(15);
		sol.enabled = false;
		textSol.text = "[color]000[wave]Which orange circle is the largest? Press the Enter Key for the answer.[wave][color]";
		seeSol = false;
	}
}
