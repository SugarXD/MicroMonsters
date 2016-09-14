using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GUIHandler : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void setExpText(){
		GameObject.Find ("Monster").GetComponent<Monster> ().increaseEXP ();
		GameObject.Find ("ExpText").GetComponent<Text> ().text = GameObject.Find ("Monster").GetComponent<Monster> ().getCurrentEXP ().ToString();
	}
}
