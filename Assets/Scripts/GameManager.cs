using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	float pressedTime;
	// Use this for initialization
	void Start () {
		pressedTime = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {

		//While mouse button is held down apply Exp.
		if (Input.GetMouseButton (0)) {
			Vector3 mousePos = Input.mousePosition;
			Vector3 screenPos = Camera.main.ScreenToWorldPoint (mousePos);
			RaycastHit2D hit = Physics2D.Raycast (screenPos, Vector2.zero);
			if (hit.collider.name.Equals ("Monster")) {
				pressedTime += Time.deltaTime;
				applyMultiplier (pressedTime);
				applyExp ();

			}
		} 
		else {
			pressedTime = 0;
		}
	}

	public void applyExp(){
		Camera.main.GetComponent<GUIHandler> ().setExpText ();
	}

	public void applyMultiplier(double pressedTime){
		if ((pressedTime * 10) >= 30) {
			GameObject.Find ("Monster").GetComponent<Monster> ().setMultiplier (0.2);
			pressedTime = 0;
		}
	}

}
