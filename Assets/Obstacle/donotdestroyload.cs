using UnityEngine;
using System.Collections;

public class donotdestroyload : MonoBehaviour {

	public static donotdestroyload control; 

	void Awake() {
		if (control == null) {
			DontDestroyOnLoad (gameObject);
			control = this; 
		} else if (control != this) {
			Destroy (gameObject); 
		}
	}
}
