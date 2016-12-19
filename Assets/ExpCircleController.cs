using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ExpCircleController : MonoBehaviour {
	public double maxEXP;
	public double currentEXP;
	public Image EXP_Circle;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		maxEXP = GameObject.Find ("Monster").GetComponent<Monster> ().getMaxEXP ();
		currentEXP = GameObject.Find ("Monster").GetComponent<Monster> ().getCurrentEXP ();
		EXP_Circle.fillAmount = (float)(currentEXP / maxEXP);
	}
}
