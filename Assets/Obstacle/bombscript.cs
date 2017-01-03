using UnityEngine;
using System.Collections;

public class bombscript : MonoBehaviour {
	public int power; 
	public GameObject explosion; 
	private Rigidbody2D trumpbody2d; 
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other) {

		if (other.tag == "Player") {
			trumpbody2d = other.GetComponent<Rigidbody2D> (); 
			trumpbody2d.AddForce( new Vector2 (0.1f, 1) * power); 
			Instantiate (explosion, new Vector2 (transform.position.x, transform.position.y + 4), transform.rotation);
			Destroy(gameObject); 
		}
	}
}
