using UnityEngine;
using System.Collections;

public class MoveEnemy : MonoBehaviour {
	public float forceX;
	public float forceY;
	// Use this for initialization
	void Start () {
		int randomNumber = Random.Range (0, 3);
		switch (randomNumber) {
		case 0: forceX = -50f;
				forceY = 10f;
				break;
		
		case 1:	forceX = -50f;
				forceY = -10f;
				break;

		case 2: forceX = -50f;
				forceY = 0f;
				break;
		}
		//Random speed
		float speed = Random.Range (1f,2f);
		Vector2 force = new Vector2 (forceX * speed, forceY * speed);
		GetComponent<Rigidbody2D> ().AddForce (force);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
