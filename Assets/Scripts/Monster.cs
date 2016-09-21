using UnityEngine;
using System.Collections;

public class Monster : MonoBehaviour {
	int currentLevel, maxLevel;
	double currentEXP, maxEXP;

	// Use this for initialization
	void Start () {
		currentEXP = 0;
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
