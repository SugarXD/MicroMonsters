using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/* The GUIHandler class will be responsible for updateing the look of GUI Elements. */

public class GUIHandler : MonoBehaviour
{
	public Sprite monsterpressed;
	public Sprite shoppressed;
	public Sprite recordspressed;
	public Sprite settingspressed;
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
		GameObject.Find ("ExpText").GetComponent<Text> ().text = "EXP: " + GameObject.Find ("Monster").GetComponent<Monster> ().getCurrentEXP ().ToString ("F0")
			+ " / " + GameObject.Find("Monster").GetComponent<Monster>().getMaxEXP().ToString("F0");
	}

	public void setCrownsText(){
		GameObject.Find ("CrownsText").GetComponent<Text> ().text = GameObject.Find ("Main Camera").GetComponent<Player> ().getCrowns ().ToString ();
	}

	public void monsterButtonHighlight(){
		GameObject.Find ("MonsterButton").GetComponent<Image> ().sprite = monsterpressed;
	}

	public void recordsButtonHighlight(){
		GameObject.Find ("RecordsButton").GetComponent<Image> ().sprite = recordspressed;
	}

	public void shopButtonHighlight(){
		GameObject.Find ("ShopsButton").GetComponent<Image> ().sprite = shoppressed;
	}

	public void settingsButtonHighlight(){
		GameObject.Find ("SettingsButton").GetComponent<Image> ().sprite = settingspressed;
	}
}
