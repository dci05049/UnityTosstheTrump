using UnityEngine;
using System.Collections;

public class TrumpPhysics : MonoBehaviour {

	public Rigidbody2D body2d; 
	private TrumpShoot trumpshootscript; 
	private SpriteRenderer spriterenderer; 
	public Sprite [] trumphitsground; 
	public int spritenumber = 0; 
	public bool brokewall; 

	private Transform groundcheck;
	public bool grounded; 

	public GameObject bloodmark; 

	private Transform groundobject;
	private float distancefromground; 

	public bool trumpbeat = false; 
	public bool trumpdead = false; 

	private PlayerCurrentGear playergearscript; 
	private GameInfoScript gameinfoscript; 

	public Sprite planehitsprite; 
	AudioSource hitground; 

	public AudioClip spikesound; 
	public AudioClip hitsound;
	public AudioClip moneysound; 

	// Use this for initialization
	void Start () {
		body2d = GetComponent<Rigidbody2D> ();
		trumpshootscript = GameObject.FindObjectOfType<TrumpShoot> ();
		spriterenderer = GetComponent<SpriteRenderer> (); 

		groundcheck = GameObject.Find ("groundcheck").transform; 
		groundobject = GameObject.Find ("ground").transform; 
		playergearscript = GameObject.FindObjectOfType<PlayerCurrentGear> (); 
	}
	
	// Update is called once per frame
	void Update () {
		grounded = Physics2D.Linecast (transform.position, groundcheck.position, 1 << LayerMask.NameToLayer ("ground"));
		distancefromground = transform.position.y - groundobject.position.y; 

		if (trumpshootscript.shoot && trumpbeat) {
			spriterenderer.sprite = trumphitsground [spritenumber]; 
		}

		if (body2d.velocity.x == 0 && body2d.velocity.y == 0 && trumpshootscript.shoot && trumpbeat) {
			trumpdead = true; 
		}

		gameinfoscript = GameObject.FindObjectOfType<GameInfoScript> ().GetComponent<GameInfoScript> (); 
		gameinfoscript.distancetravelled = transform.position.x + 7.21f;

		if (body2d.velocity.y > 0 && body2d.velocity.x == 0) {
			body2d.velocity = new Vector2 (0.5f, body2d.velocity.y); 
		}

	
	}

	void RotateLeft () {
		if (distancefromground > 7 || body2d.velocity.x > 3) {
			transform.Rotate (Vector3.forward * -130 * Time.deltaTime);
		}
	}
	
	public void trumpShootFunction (int strength, Vector2 direction) {
		body2d.AddForce (direction * strength);
	}

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.collider.tag == "spike") {
			body2d.isKinematic = true;
			trumpdead = true; 
			hitground = GetComponent<AudioSource> (); 
			hitground.clip = spikesound; 
			hitground.Play ();
		}

		if (coll.collider.tag == "ground" && trumpshootscript.shoot && body2d.velocity.x > 0.5f && Mathf.Abs (body2d.velocity.y) > 3f) {
			trumpbeat = true;
			if (spritenumber < 2) {
				spritenumber += 1; 
			} else {
				spritenumber = 0; 
			}
			body2d.freezeRotation = true;

			hitground = GetComponent<AudioSource> (); 
			hitground.clip = hitsound; 
			hitground.Play ();

			transform.rotation = new Quaternion (0, 0, 0, 0);
		} else {
			hitground = GetComponent<AudioSource> (); 
			hitground.clip = hitsound; 
			hitground.Play ();
		}

		if (trumpshootscript.shoot) {
			Instantiate (bloodmark, new Vector2 (transform.position.x, -3.5f), bloodmark.transform.rotation);
		}
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "money") {
			hitground = GetComponent<AudioSource> (); 
			hitground.clip = moneysound; 
			hitground.Play ();
			Destroy(other.gameObject);
			GameInfoScript.gameinfocontrol.Trumpmoney += 1000; 
			GameInfoScript.gameinfocontrol.TotalEarned += 1000; 
		}

		if (other.tag == "plane") {
			GetComponent<SpriteRenderer> ().sprite = planehitsprite; 
			transform.position = new Vector2 (other.transform.position.x + 10f, other.transform.position.y); 
			body2d.gravityScale = 0; 

		}
	}

	void FixedUpdate () {
		if (trumpshootscript.shoot && !grounded) {
			RotateLeft ();
		}

		if (grounded) {
			body2d.freezeRotation = true;
		}
	}
	
}
