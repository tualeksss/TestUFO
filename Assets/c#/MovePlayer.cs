using UnityEngine;
using System.Collections;

public class MovePlayer : MonoBehaviour {
	public KeyCode moveUp;
	public KeyCode moveDown;
	public KeyCode moveLeft;
	public KeyCode moveRight;
	public float speed = 10f;
	public Rigidbody2D rb2D;
	// Use this for initialization
	void Start () {
		rb2D = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void FixedUpdate(){
		if (Input.GetKey (moveUp)) {
			rb2D.velocity = new Vector2 (0, speed);
		} else if (Input.GetKey (moveDown)) {
			rb2D.velocity = new Vector2 (0, speed * -1);
		} else if (Input.GetKey (moveLeft)) {
			rb2D.velocity = new Vector2 (speed * -1, 0);
			transform.localScale = new Vector3(-0.4f,0.4f,0.4f);
		} else if (Input.GetKey (moveRight)) {
			rb2D.velocity = new Vector2 (speed, 0);
			transform.localScale = new Vector3(0.4f,0.4f,0.4f);
		} else {
			rb2D.velocity = new Vector2 (0,0);
		}
	}
	void Update () {
	
	}
}
