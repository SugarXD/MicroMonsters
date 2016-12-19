using UnityEngine;
using System.Collections;

public class Monster : MonoBehaviour {
	int currentLevel, stage;
	const int MAX_LEVEL = 100;
	double currentEXP, maxEXP;

	// Use this for initialization
	void Start () {
		currentEXP = 0;
		currentLevel = 1;
		stage = 0;
		maxEXP = 1000;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void increaseEXP(double multiplier){
		currentEXP += 1 * multiplier;
		if (currentEXP >= maxEXP) {
			currentLevel++;
			maxEXP += 200;
			currentEXP = 0;
			//increase Money ammount.
			GameObject.Find("Main Camera").GetComponent<Player>().increaseCrowns();
			GameObject.Find ("Main Camera").GetComponent<GUIHandler> ().setCrownsText ();
		}
	}

	public double getCurrentEXP(){
		return currentEXP;
	}

	public double getMaxEXP(){
		return maxEXP;
	}
		
}
