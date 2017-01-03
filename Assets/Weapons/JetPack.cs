using UnityEngine;
using System.Collections;

public class JetPack : MonoBehaviour {

	public bool usedjetpack;  

	private GameObject trumpobject; 
	public Sprite Trumpjetpacksprite; 
	public Sprite Jetpack; 

	public float rocketduration; 
	private PlayerCurrentItem playeritemscript; 
	private TrumpShoot trumpshootscript; 
	private AudioSource jetpackaudio; 
	private bool playedaudio = false; 
	// Use this for initialization
	void Start () {
		GetComponent<SpriteRenderer> ().sprite = null; 
	}
	
	// Update is called once per frame
	void Update () {
		trumpobject = GameObject.FindObjectOfType<TrumpPhysics> ().gameObject; 
		playeritemscript = GameObject.FindObjectOfType<PlayerCurrentItem> (); 
		trumpshootscript = GameObject.FindObjectOfType<TrumpShoot> (); 

		if (trumpshootscript.shoot) {
			GetComponent<SpriteRenderer> ().sprite = Jetpack; 
		}

		if (playeritemscript.jetpack && trumpshootscript.shoot) {
			if (Input.GetKeyDown ("w")) {
				usedjetpack = true; 
			}
		}

		if (usedjetpack) {
			trumpobject.GetComponent<SpriteRenderer> ().sprite = Trumpjetpacksprite;
			trumpobject.GetComponent<Rigidbody2D> ().gravityScale = 0; 
			trumpobject.GetComponent<Rigidbody2D> ().velocity = new Vector2 (trumpobject.GetComponent<Rigidbody2D> ().velocity.x, 0); 
			trumpobject.transform.rotation = Quaternion.Euler (0,0,334.9f);
			rocketduration += Time.deltaTime; 
			if (!playedaudio) {
				jetpackaudio = GetComponent<AudioSource> (); 
				jetpackaudio.Play ();
				playedaudio = true;
			}

			if (rocketduration > 4) {
				trumpobject.GetComponent<Rigidbody2D> ().gravityScale = 1.5f;
				Destroy (gameObject); 
			}
		}
	}
}
