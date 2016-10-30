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
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void increaseEXP(double multiplier){
		currentEXP += 1 * multiplier;
	}

	public double getCurrentEXP(){
		return currentEXP;
	}

	public double getMaxEXP(){
		return maxEXP;
	}
		
}
