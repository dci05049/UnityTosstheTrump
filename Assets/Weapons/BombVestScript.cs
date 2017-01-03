using UnityEngine;
using System.Collections;

public class BombVestScript : MonoBehaviour {

	public GameObject explosion; 
	private TrumpShoot trumpshootscript; 
	private Rigidbody2D trumpbody2d; 
	private PlayerCurrentItem playeritemscript; 

	private float explodetime = 3; 
	private float countertime = 0; 

	private bool usedvest = false; 
	// Use this for initialization
	void Start () {
		GetComponent<SpriteRenderer> ().enabled = false; 
	}
	
	// Update is called once per frame
	void Update () {

		playeritemscript = GameObject.FindObjectOfType<PlayerCurrentItem> (); 

		if (playeritemscript.bombvest && !usedvest) {
			trumpshootscript = GameObject.FindObjectOfType<TrumpShoot> ().GetComponent<TrumpShoot> (); 
			trumpbody2d = GameObject.FindObjectOfType<TrumpPhysics> ().GetComponent<Rigidbody2D> (); 
			if (trumpshootscript.shoot) {
				GetComponent<SpriteRenderer> ().enabled = true; 
				countertime += Time.deltaTime; 
				if (countertime > explodetime) {
					Instantiate (explosion, transform.position, transform.rotation);
					trumpbody2d.AddForce (Vector2.up * 1500); 
					usedvest = true; 
					Destroy (gameObject);
				}
			}
		}
	}
}
