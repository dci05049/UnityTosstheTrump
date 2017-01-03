using UnityEngine;
using System.Collections;

public class gamenew : MonoBehaviour {

	private PlayerCurrentGear playergerascript;
	private PlayerCurrentItem playeritemscript;

	// Use this for initialization
	void Start () {
		playergerascript = GameObject.FindObjectOfType<PlayerCurrentGear> (); 
		playeritemscript = GameObject.FindObjectOfType<PlayerCurrentItem> (); 
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("n")) {
			playergerascript.launchernumber = 0; 
			playeritemscript.jetpack = false; 
			playeritemscript.bombvest = false; 
		}
	}
}
