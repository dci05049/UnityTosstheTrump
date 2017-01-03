using UnityEngine;
using System.Collections;

public class DoNotDestroy : MonoBehaviour {
	public static DoNotDestroy control; 

	void Awake() {
		if (control == null) {
			DontDestroyOnLoad (gameObject);
			control = this; 
		} else if (control != this) {
			Destroy (gameObject); 
		}
	}
		
}
