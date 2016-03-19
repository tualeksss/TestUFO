using UnityEngine;
using System.Collections;

public class SpawnPoulpi : MonoBehaviour {

	public Transform PoulpiPrefab;

	// Use this for initialization
	void Start () {

		InvokeRepeating ("spawn",1f,3f);

	}
	
	// Update is called once per frame
	void spawn () {
		Transform shotTransform = Instantiate (PoulpiPrefab);
		shotTransform.position = transform.position;
	}
}
