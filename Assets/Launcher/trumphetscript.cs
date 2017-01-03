using UnityEngine;
using System.Collections;

public class trumphetscript : MonoBehaviour {
	
	private PlayerCurrentGear playergearscript; 
	private TrumpShoot trumpshootscript; 
	private GameObject donaldtrump; 
	// Use this for initialization
	void Start () {
		trumpshootscript = GameObject.FindObjectOfType<TrumpShoot> ().GetComponent<TrumpShoot> (); 
		playergearscript = GameObject.FindObjectOfType<PlayerCurrentGear> ();
	}

	// Update is called once per frame
	void Update () {
		donaldtrump = GameObject.Find ("Trump"); 

		if (!trumpshootscript.shoot && playergearscript.launchernumber == 2) {
			donaldtrump.GetComponent<Rigidbody2D> ().isKinematic = true;
			donaldtrump.GetComponent<SpriteRenderer> ().enabled = false;
		} else if (trumpshootscript.shoot && playergearscript.launchernumber == 2) {
			donaldtrump.GetComponent<SpriteRenderer> ().enabled = true;
		}
	}
}
