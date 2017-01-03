using UnityEngine;
using System.Collections;

public class TrumpCamera : MonoBehaviour {

	private TrumpShoot trumpshootscript; 
	private Transform trumpposition; 
	private GameObject trumpobject; 

	private float trumpposition_y; 

	private bool movecamera; 

	// Use this for initialization
	void Start () {
		trumpshootscript = GameObject.FindObjectOfType<TrumpShoot> ();
		trumpposition = GameObject.Find ("Trump").transform; 
	}
	
	// Update is called once per frame
	void Update () {
		trumpobject = GameObject.FindObjectOfType<TrumpPhysics> ().gameObject; 

		if (!trumpobject.GetComponent<SpriteRenderer> ().flipX) {
			transform.position = new Vector3 (trumpposition.position.x + 12f, Mathf.Clamp (trumpposition.position.y - 2f, 7.48f, float.MaxValue), transform.position.z);
		} else { 
			transform.position = new Vector3 (trumpposition.position.x + 7f, Mathf.Clamp (trumpposition.position.y - 2f, 7.48f, float.MaxValue), transform.position.z);
		}

	}
}
