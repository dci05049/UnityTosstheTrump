using UnityEngine;
using System.Collections;

public class backgroundsound : MonoBehaviour {
	private AudioSource backgroundaudio; 
	// Use this for initialization
	void Start () {
		backgroundaudio = GetComponent<AudioSource> (); 
		backgroundaudio.Play ();
	}
	
	// Update is called once per frame
	void Update () {

	}
}
