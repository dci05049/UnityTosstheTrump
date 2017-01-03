using UnityEngine;
using System.Collections;

public class RocketControlScript : MonoBehaviour {
	public GameObject cannon; 
	public GameObject northkorean; 
	public GameObject trumphet; 
	public GameObject hairdryer; 

	private PlayerCurrentGear playergearscript;

	// Use this for initialization
	void Start () {
		playergearscript = GameObject.FindObjectOfType <PlayerCurrentGear> (); 
	}
	
	// Update is called once per frame
	void Update () {
		if (playergearscript.launchernumber == 0) {
			cannon.SetActive (true); 
		} else {
			cannon.SetActive (false); 
		}

		if (playergearscript.launchernumber == 1) {
			hairdryer.SetActive (true); 
		} else {
			hairdryer.SetActive (false); 
		}

		if (playergearscript.launchernumber == 2) {
			trumphet.SetActive (true); 
		} else {
			trumphet.SetActive (false); 
		}

		if (playergearscript.launchernumber == 3) {
			northkorean.SetActive (true); 
		} else {
			northkorean.SetActive (false);
		}
	} 
}
