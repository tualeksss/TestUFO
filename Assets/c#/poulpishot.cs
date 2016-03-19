using UnityEngine;
using System.Collections;

public class poulpishot : MonoBehaviour {

	public Transform PoulpishotPrefab;
	
	// Use this for initialization
	void Start () {
		
		InvokeRepeating ("spawn",1f,2f);
		
	}
	
	// Update is called once per frame
	void spawn () {
		Transform shotTransform = Instantiate (PoulpishotPrefab);
		shotTransform.position = transform.position;
	}
}