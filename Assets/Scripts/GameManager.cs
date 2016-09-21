using UnityEngine;
using System.Collections;
/* The GameManager Script will be responsible for all main gameplay mechanics. This includes keeping track of time and issueing commands respective to user input.*/


public class GameManager : MonoBehaviour {
	
	float pressedTime; 
	double multiplier;
	public double increment;

	// Use this for initialization
	void Start () {
		pressedTime = 0.0f;
		multiplier = 1.0;
		increment = 0.2;
	}
	
	// Update is called once per frame
	void Update () {

		/* While mouse button is held down, if it "hits" the monster target then increase the amount of time pressed and check to see if the multiplier needs to be updated.
		Will also apply the EXP to the monster and signal the GUI to update text. */
		if (Input.GetMouseButton (0)) {
			Vector3 mousePos = Input.mousePosition;
			Vector3 screenPos = Camera.main.ScreenToWorldPoint (mousePos);
			RaycastHit2D hit = Physics2D.Raycast (screenPos, Vector2.zero);
			if (hit.collider.name.Equals ("Monster")) {
				pressedTime += Time.deltaTime;
				pressedTime = applyMultiplier (pressedTime);
				print (pressedTime);
				applyExp (multiplier);

			}
		} 
		//If the user lets go of the monster the pressedTime will be reset.
		else {
			pressedTime = 0;
		}
	}

	/* Apply EXP to the current monster and set GUI Text. */
	public void applyExp(double multiplier){
		GameObject.Find ("Monster").GetComponent<Monster> ().increaseEXP (multiplier);
		Camera.main.GetComponent<GUIHandler> ().setExpText ();
	}

	/*Check to see if the multiplier needs to be incremented. */
	public float applyMultiplier(float pressedTime){
		if ((pressedTime * 1) >= 30) {
			multiplier += increment;
			return pressedTime = 0;

		}
		return pressedTime;
	}

}
