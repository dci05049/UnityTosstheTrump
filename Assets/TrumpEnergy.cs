using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class TrumpEnergy : MonoBehaviour {
	public int valueCurrent = 1;
	private int max = 100; 
	private int min = 0; 
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (valueCurrent > max) {
			valueCurrent = max;
		} else if (valueCurrent < 0) {
			valueCurrent = min; 
		}

		gameObject.GetComponent<RectTransform> ().localPosition = new Vector2 (-76f + (1.7f * valueCurrent), -152.7f);
	}
}
