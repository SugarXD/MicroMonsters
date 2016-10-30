using UnityEngine;
using System.Collections;

/* The GameManager Script will be responsible for all main gameplay mechanics. This includes keeping track of time and issueing commands respective to user input.*/


public class GameManager : MonoBehaviour {
	
	float pressedTime; 
	double multiplier;
	public double increment;
	public const string path = "events";
	System.Random rnd = new System.Random();
	public bool isMonsterPressed = false;
	EventContainer ec;

	void Start () {
		pressedTime = 0.0f;
		multiplier = 1.0;
		increment = 0.2;

		//loadEvents
		ec = EventContainer.Load (path);
	}

	void Update () {

		/* While mouse button is held down, if it "hits" the monster target then increase the amount of time pressed and check to see if the multiplier needs to be updated.
		Will also apply the EXP to the monster and signal the GUI to update text. */
		if(isMonsterPressed){
				pressedTime += Time.deltaTime;
				pressedTime = applyMultiplier (pressedTime);
				applyExp (multiplier);
				generateEvent (rnd);
		} 
	}

	public void onPointerDownMonster(){
		isMonsterPressed = true;
	}

	public void onPointerUpMonster(){
		isMonsterPressed = false;
		pressedTime = 0;
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

	public void generateEvent(System.Random rnd){
		int num = rnd.Next(1, 100000);
		if (num == 1) {
			Event randEvent = ec.getRandomEvent ();
			Debug.Log (randEvent.name);
		}
	}

}
