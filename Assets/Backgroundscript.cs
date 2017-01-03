using UnityEngine;
using System.Collections;

public class Backgroundscript : MonoBehaviour {

	private Transform trumptransform; 
	// Use this for initialization
	void Start () {
		trumptransform = GameObject.FindGameObjectWithTag ("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (trumptransform.position.x, transform.position.y, transform.position.z);
	}
}
