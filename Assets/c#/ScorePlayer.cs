using UnityEngine;
using System.Collections;

public class ScorePlayer : MonoBehaviour {
	
	static int playerscore = 10;
	
	// Use this for initialization
	void Start () {
		
	}
	void OnTriggerEnter2D(Collider2D hitInfo) {	
		if (hitInfo.gameObject.tag == "Enemy") {
			playerscore -= 2;
			Destroy (hitInfo.gameObject);
		}if (hitInfo.gameObject.tag == "shot") {
			playerscore -= 1;
			Destroy (hitInfo.gameObject);
		}
	}
	public GUISkin mySkin;
	void OnGUI(){
		GUI.skin = mySkin;
		GUI.Label (new Rect (10, 10, 100, 100), "" + (playerscore + MoveShot.playerscore));
		
		if (playerscore == 0) {
			GUI.Label (new Rect(Screen.width/2 - 100 , Screen.height/2, 250, 60), "Game Over");
			Time.timeScale = 0;
		}
	}
}