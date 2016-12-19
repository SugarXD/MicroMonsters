using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	int crowns;
	// Use this for initialization
	void Start () {
		crowns = 200;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public int getCrowns(){
		return crowns;
	}
	public void setCrowns(int crowns){
		this.crowns = crowns;
	}
	public void increaseCrowns(){
		crowns += 150;
	}
}
