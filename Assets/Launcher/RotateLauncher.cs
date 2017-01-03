using UnityEngine;
using System.Collections;

public class RotateLauncher : MonoBehaviour {
	private Vector3 mouseposition; 
	public float speed; 

	private TrumpShoot trumpscript; 
	// Use this for initialization
	void Start () {
		trumpscript = GameObject.FindObjectOfType<TrumpShoot> ().GetComponent<TrumpShoot> (); 
	}
	
	// Update is called once per frame
	void Update () {
		if (!trumpscript.shoot) {
			mouseposition = Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, +12.3f));
			Vector3 lookpos = mouseposition - transform.position; 
			float angle = Mathf.Atan2 (lookpos.y, lookpos.x) * Mathf.Rad2Deg; 
			transform.rotation = Quaternion.AngleAxis (angle, Vector3.forward); 
		}
	}
}

