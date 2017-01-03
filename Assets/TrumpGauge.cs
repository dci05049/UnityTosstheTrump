using UnityEngine;
using System.Collections;

public class TrumpGauge : MonoBehaviour {

	public int multipler = 4; 
	private TrumpEnergy energybarscript; 
	private TrumpShoot trumpshootscript;
	private bool trumpshot = false; 

	private float currenttime = 0; 
	private float waittime = 0.0000005f; 

	// Use this for initialization
	void Start () {
		energybarscript = GameObject.FindObjectOfType<TrumpEnergy> (); 
		trumpshootscript = GameObject.FindObjectOfType<TrumpShoot> ();
	}
	
	// Update is called once per frame
	void Update () {
	}

	void FixedUpdate () {
		if (trumpshootscript.shoot) {
			trumpshot = true;
		}
		
		if (Time.time > currenttime && !trumpshot) {
			currenttime = Time.time + waittime;
			energybarscript.valueCurrent += multipler;
		}

		if (energybarscript.valueCurrent >= 100) {
			multipler *= -1;
		} else if (energybarscript.valueCurrent <= 0) {
			multipler *= -1;
		}
			
	}

}
