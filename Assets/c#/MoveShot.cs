using UnityEngine;
using System.Collections;

public class MoveShot : MonoBehaviour {
	
	public Vector2 speed = new Vector2(20,10);
	public Vector2 direction = new Vector2 (1,0);
	public Vector2 movement = new Vector2 (0,0);
	public static int playerscore = 0;
	// Use this for initialization
	void Start () {
		movement = new Vector2 (speed.x * direction.x, speed.y * direction.y);
		Rigidbody2D rb = GetComponent<Rigidbody2D> ();
		rb.AddForce (movement);
	}

	void OnTriggerEnter2D(Collider2D hitInfo) {	
		if (hitInfo.gameObject.tag == "Enemy") {
			playerscore += 2;
			Destroy (hitInfo.gameObject);
			Destroy (gameObject);
		}if (hitInfo.gameObject.tag == "shot") {
			Destroy (gameObject);
			Destroy (hitInfo.gameObject);
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}
