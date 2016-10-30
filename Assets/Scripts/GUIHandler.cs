using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/* The GUIHandler class will be responsible for updateing the look of GUI Elements. */

public class GUIHandler : MonoBehaviour
{
	
	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	/* Update EXP text. */
	public void setExpText (){
		GameObject.Find ("ExpText").GetComponent<Text> ().text = GameObject.Find ("Monster").GetComponent<Monster> ().getCurrentEXP ().ToString ("F2");
		//print(GameObject.Find("Monster").GetComponent<Monster>().getCurrentEXP().ToString("F2"));
	}
}
