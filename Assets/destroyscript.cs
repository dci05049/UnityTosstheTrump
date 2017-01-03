using UnityEngine;
using System.Collections;

public class destroyscript : MonoBehaviour {
	private GameObject trump; 
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		trump = GameObject.FindObjectOfType<TrumpPhysics> ().gameObject; 
		if (transform.position.x < trump.transform.position.x - 3) {
			Destroy (gameObject, 1);
		}
	}
}
