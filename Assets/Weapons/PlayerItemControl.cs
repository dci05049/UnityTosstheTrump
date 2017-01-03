using UnityEngine;
using System.Collections;

public class PlayerItemControl : MonoBehaviour {
	private GameObject bombvestobject; 
	private GameObject jetpackobject;

	private PlayerCurrentItem playeritemscript; 
	// Use this for initialization
	void Start () {
		playeritemscript = GameObject.FindObjectOfType<PlayerCurrentItem> ().GetComponent<PlayerCurrentItem> (); 
		bombvestobject = GameObject.Find ("bombvest"); 
		jetpackobject = GameObject.Find ("Jetpack"); 

		if (playeritemscript.bombvest) {
			bombvestobject.SetActive (true); 
		} else {
			bombvestobject.SetActive (false); 
		}

		if (playeritemscript.jetpack) {
			jetpackobject.SetActive (true); 
		} else {
			jetpackobject.SetActive (false); 
		}


	}
	
	// Update is called once per frame
	void Update () {

	}
}
