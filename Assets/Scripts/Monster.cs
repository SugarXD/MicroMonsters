using UnityEngine;
using System.Collections;

public class Monster : MonoBehaviour {
	int currentLevel, maxLevel;
	double currentEXP, maxEXP, multiplier;

	// Use this for initialization
	void Start () {
		currentEXP = 0;
		multiplier = 1.0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void increaseEXP(){
		currentEXP += 1 * multiplier;
	}

	public double getCurrentEXP(){
		return currentEXP;
	}

	public double getMaxEXP(){
		return maxEXP;
	}

	public void setMultiplier(double increment){
		multiplier += increment;
		print (multiplier);
	}
}
