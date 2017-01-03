using UnityEngine;
using System.Collections;

public class planescript : MonoBehaviour {
	private bool usedplane;  
	private bool usingplane; 
	public GameObject explosion; 

	private GameObject trumpobject; 
	public Sprite planesprite; 

	public float planeduration; 
	private PlayerCurrentItem playeritemscript; 
	private AudioSource planeaudio; 
	private bool playedaudio = false;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		trumpobject = GameObject.FindObjectOfType<TrumpPhysics> ().gameObject; 
		playeritemscript = GameObject.FindObjectOfType<PlayerCurrentItem> (); 
		if (usingplane) {
			trumpobject.GetComponent<SpriteRenderer> ().sprite = planesprite;
			trumpobject.GetComponent<Rigidbody2D> ().gravityScale = 0; 
			trumpobject.GetComponent<Rigidbody2D> ().velocity = new Vector2 (trumpobject.GetComponent<Rigidbody2D> ().velocity.x, 0); 
			trumpobject.transform.rotation = Quaternion.Euler (0,0,334.9f);
			planeduration += Time.deltaTime; 
			transform.position = new Vector2 (trumpobject.transform.position.x - 7.5f, trumpobject.transform.position.y - 1f);

			if (!playedaudio) {
				planeaudio = GetComponent<AudioSource> (); 
				planeaudio.Play (); 
				playedaudio = true; 
			}
			if (planeduration > 4) {
				trumpobject.GetComponent<Rigidbody2D> ().gravityScale = 1.5f;
				trumpobject.GetComponent<SpriteRenderer> ().flipX = false; 
				Instantiate (explosion, new Vector2 (transform.position.x + 10f, transform.position.y + 6f), transform.rotation);
				Destroy (gameObject); 
			}
		}

		transform.Translate (Vector2.right * Time.deltaTime * 10);

	}

	void OnTriggerEnter2D(Collider2D other) {

		if (other.tag == "Player") {
			trumpobject.GetComponent<Rigidbody2D> ().gravityScale = 0f; 
			usingplane = true; 
			other.GetComponent<SpriteRenderer> ().flipX = true;
			other.GetComponent<Rigidbody2D> ().velocity = new Vector2 (50f, 0); 
		}
	}
}
