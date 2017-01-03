using UnityEngine;
using System.Collections;

public class explosionscript : MonoBehaviour {
	AudioSource explosionaudio; 
	// Use this for initialization
	void Start () {
		explosionaudio = GetComponent<AudioSource> (); 
		explosionaudio.Play (); 
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
