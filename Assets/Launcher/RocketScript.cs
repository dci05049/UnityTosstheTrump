using UnityEngine;
using System.Collections;

public class RocketScript : MonoBehaviour {

	public bool rocketequipped; 
	private TrumpShoot trumpshootscript; 
	private GameObject donaldtrump; 

	public bool rocketexplode; 
	public GameObject explosion; 

	private float timeexplode = 2; 
	private float counterexplode; 
	private PlayerCurrentGear playergearscript; 
	private AudioSource rocketaudio; 
	private bool playedaudio = false; 

	// Use this for initialization
	void Start () {
		trumpshootscript = GameObject.FindObjectOfType<TrumpShoot> ().GetComponent<TrumpShoot> (); 
		playergearscript = GameObject.FindObjectOfType<PlayerCurrentGear> (); 
	}
	
	// Update is called once per frame
	void Update () {
		donaldtrump = GameObject.Find ("Trump"); 

		if (!trumpshootscript.shoot && playergearscript.launchernumber == 3) {
			donaldtrump.GetComponent<Rigidbody2D> ().isKinematic = true;
			donaldtrump.GetComponent<SpriteRenderer> ().enabled = false;
		} else if (trumpshootscript.shoot && playergearscript.launchernumber == 3) {

			RocketScript rocketscript = GameObject.FindObjectOfType<RocketScript> ().GetComponent<RocketScript> (); 
			if (!rocketscript.rocketexplode) {
				donaldtrump.GetComponent<SpriteRenderer> ().enabled = false; 
			} else if (rocketscript.rocketexplode) {
				donaldtrump.GetComponent<SpriteRenderer> ().enabled = true; 
				Destroy (gameObject); 
			}
		}

		if (trumpshootscript.shoot) {

			transform.position = GameObject.FindObjectOfType<TrumpPhysics> ().transform.position; 
			if (!playedaudio) {
				rocketaudio = GetComponent<AudioSource> (); 
				rocketaudio.Play (); 
				playedaudio = true; 
			}
			counterexplode += Time.deltaTime; 
			if (counterexplode >= timeexplode && !rocketexplode) {
				rocketexplode = true; 
				Instantiate (explosion, transform.position, transform.rotation); 
			}
		}
	}
}
