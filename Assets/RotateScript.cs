using UnityEngine;
using System.Collections;

public class RotateScript : MonoBehaviour {

	private TrumpShoot trumpshootscript; 
	private Transform trumpobject; 

	// Use this for initialization
	void Start () {
		trumpshootscript = GameObject.FindObjectOfType<TrumpShoot> ();
		trumpobject = GameObject.Find ("Trump").transform;
	}
	
	void Update () {
		transform.position = new Vector2 (trumpobject.localPosition.x, trumpobject.localPosition.y);
		RotateLeft ();
	
	}
	
	void RotateLeft () {
		transform.Rotate (Vector3.forward * -100 * Time.deltaTime);

	}
}
