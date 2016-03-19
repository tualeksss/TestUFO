using UnityEngine;
using System.Collections;

public class Shot_poulpi : MonoBehaviour {

	public Vector2 speed = new Vector2(30,10);
	public Vector2 direction = new Vector2(-1,0);
	public Vector2 movement = new Vector2(0,0);

	// Use this for initialization
	void Start () {
		movement = new Vector2 (speed.x * direction.x,
		                        speed.y * Random.Range (-2f, 2f));
		Rigidbody2D rb = GetComponent<Rigidbody2D> ();
		rb. AddForce(movement);
	
	}

	void onTriggerEnter2D(Collider2D hitInfo){
		if (hitInfo.gameObject.tag == "Player") {
			Destroy (gameObject);
		}
	}
}
