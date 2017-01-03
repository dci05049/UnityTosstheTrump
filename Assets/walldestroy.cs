using UnityEngine;
using System.Collections;

public class walldestroy : MonoBehaviour {
	public GameObject bricksflown; 
	private TrumpPhysics trumpscript; 
	private AudioSource wallaudio; 
	private bool playedaudio;
	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D> ().constraints = RigidbodyConstraints2D.FreezePositionX; 
	}
	
	// Update is called once per frame
	void Update () {
		trumpscript = GameObject.FindObjectOfType<TrumpPhysics> ().GetComponent<TrumpPhysics> (); 
		if (trumpscript.brokewall) {
			Time.timeScale = 0.1f;
			if (!playedaudio) {
				wallaudio = GetComponent<AudioSource> (); 
				wallaudio.Play ();
				playedaudio = true; 
			}
		}
	}

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.collider.name == "Trump") {
			if (!trumpscript.brokewall) {
				Debug.Log ("hi");
				trumpscript.brokewall = true; 
				Instantiate (bricksflown, transform.position, transform.rotation); 
				Destroy (gameObject); 
			}
		}
	}
}
