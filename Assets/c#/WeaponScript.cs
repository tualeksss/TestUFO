using UnityEngine;
using System.Collections;

public class WeaponScript : MonoBehaviour {

	public Transform ShotPrefab;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		bool shoot = Input.GetButtonDown("Jump");

		if (shoot) {
			GetComponent< AudioSource> ().Play();
			Transform shotTranform = Instantiate (ShotPrefab);
			shotTranform.position = transform.position;
		}
	
	}
}
