using UnityEngine;
using System.Collections;

public class GenerateScript : MonoBehaviour {

	public GameObject[] cloud; 
	public GameObject bomb; 
	public GameObject bigbomb; 
	public GameObject spikes; 
	public GameObject money; 
	public GameObject stars; 
	public GameObject planes; 

	public float waittime = 0f;
	private float timeinterval = 2f; 
	private GameObject trumpobject; 

	private TrumpShoot trumpshootscript; 
	private TrumpPhysics trumpphysicsscript; 
	// Use this for initialization
	void Start () {
		StartCoroutine (generateBombs ()); 
		StartCoroutine (generateBigBomb ()); 
		StartCoroutine (generateClouds ()); 
		StartCoroutine (generateSpikes ()); 
		StartCoroutine (generateMoney ()); 
		StartCoroutine (generatePlanes ()); 
		StartCoroutine (generatestars ()); 
	}
	
	// Update is called once per frame
	void Update () {
		trumpobject = GameObject.FindObjectOfType<TrumpPhysics> ().gameObject; 
		transform.rotation = Quaternion.identity; 
		transform.position = trumpobject.transform.position; 
	}

	IEnumerator generateBombs () {
		while (true) {
			trumpshootscript = GameObject.FindObjectOfType<TrumpShoot> ().GetComponent<TrumpShoot> (); 
			trumpphysicsscript = GameObject.FindObjectOfType<TrumpPhysics> ().GetComponent<TrumpPhysics> (); 
			if (trumpshootscript.shoot && !trumpphysicsscript.trumpdead) {
				Instantiate (bomb, new Vector2 (trumpobject.transform.position.x + 50f, -1.2f) , transform.rotation); 
			}
			yield return new WaitForSeconds (Random.Range(10f, 15f)); 
		}
	}

	IEnumerator generateClouds () {
		while (true) {
			trumpshootscript = GameObject.FindObjectOfType<TrumpShoot> ().GetComponent<TrumpShoot> (); 
			trumpphysicsscript = GameObject.FindObjectOfType<TrumpPhysics> ().GetComponent<TrumpPhysics> (); 
			if (trumpshootscript.shoot && !trumpphysicsscript.trumpdead && trumpobject.GetComponent<Rigidbody2D> ().velocity.x > 3) {
				Instantiate (cloud[Random.Range(1,cloud.Length)], new Vector2 (trumpobject.transform.position.x + 80f, Random.Range(25f,30f)), transform.rotation); 
				Instantiate (cloud[Random.Range(1,cloud.Length)], new Vector2 (trumpobject.transform.position.x + 80f, Random.Range(35f,40f)), transform.rotation); 
				Instantiate (cloud[Random.Range(1,cloud.Length)], new Vector2 (trumpobject.transform.position.x + 80f, Random.Range(45f,50f)), transform.rotation); 
				Instantiate (cloud[Random.Range(1,cloud.Length)], new Vector2 (trumpobject.transform.position.x + 80f, Random.Range(55f,65f)), transform.rotation); 
				Instantiate (cloud[Random.Range(1,cloud.Length)], new Vector2 (trumpobject.transform.position.x + 80f, Random.Range(70f,75f)), transform.rotation); 
			}
			yield return new WaitForSeconds (Random.Range(0.5f, 1f)); 
		}
	}

	IEnumerator generatestars () {
		while (true) {
			trumpshootscript = GameObject.FindObjectOfType<TrumpShoot> ().GetComponent<TrumpShoot> (); 
			trumpphysicsscript = GameObject.FindObjectOfType<TrumpPhysics> ().GetComponent<TrumpPhysics> (); 
			if (trumpshootscript.shoot && !trumpphysicsscript.trumpdead &&  trumpobject.GetComponent<Rigidbody2D> ().velocity.x > 3) {
				Instantiate (stars, new Vector2 (trumpobject.transform.position.x + 80f, Random.Range(160f,230f)), transform.rotation);
				Instantiate (stars, new Vector2 (trumpobject.transform.position.x + 80f, Random.Range(250f,280f)), transform.rotation);
				Instantiate (stars, new Vector2 (trumpobject.transform.position.x + 80f, Random.Range (250f, 280f)), transform.rotation);
				Instantiate (stars, new Vector2 (trumpobject.transform.position.x + 80f, Random.Range (250f, 280f)), transform.rotation);
				Instantiate (stars, new Vector2 (trumpobject.transform.position.x + 80f, Random.Range(290f,310f)), transform.rotation); 
			}
			yield return new WaitForSeconds (Random.Range(0.5f, 1f)); 
		}
	}

	IEnumerator generateSpikes () {
		while (true) {
			trumpshootscript = GameObject.FindObjectOfType<TrumpShoot> ().GetComponent<TrumpShoot> (); 
			trumpphysicsscript = GameObject.FindObjectOfType<TrumpPhysics> ().GetComponent<TrumpPhysics> (); 
			if (trumpshootscript.shoot && !trumpphysicsscript.trumpdead) {
				Instantiate (spikes, new Vector2 (trumpobject.transform.position.x + 50f, -1.8f) , transform.rotation); 
			}
			yield return new WaitForSeconds (Random.Range(5f, 10f)); 
		}
	}

	IEnumerator generateMoney () {
		while (true) {
			trumpshootscript = GameObject.FindObjectOfType<TrumpShoot> ().GetComponent<TrumpShoot> (); 
			trumpphysicsscript = GameObject.FindObjectOfType<TrumpPhysics> ().GetComponent<TrumpPhysics> (); 
			if (trumpshootscript.shoot && !trumpphysicsscript.trumpdead &&  trumpobject.GetComponent<Rigidbody2D> ().velocity.x > 3) {
				Instantiate (money, new Vector2 (trumpobject.transform.position.x + 80f, Random.Range(25f,60f)), transform.rotation);  
				Instantiate (money, new Vector2 (trumpobject.transform.position.x + 80f, Random.Range(25f,60f)), transform.rotation); 
			}
			yield return new WaitForSeconds (Random.Range(1f, 2f)); 
		}
	}

	IEnumerator generateBigBomb () {
		while (true) {
			trumpshootscript = GameObject.FindObjectOfType<TrumpShoot> ().GetComponent<TrumpShoot> (); 
			trumpphysicsscript = GameObject.FindObjectOfType<TrumpPhysics> ().GetComponent<TrumpPhysics> (); 
			if (trumpshootscript.shoot && !trumpphysicsscript.trumpdead &&  trumpobject.GetComponent<Rigidbody2D> ().velocity.x > 3) {
				Instantiate (bigbomb, new Vector2 (trumpobject.transform.position.x + 50f, 0.7435f) , transform.rotation);
			}
			yield return new WaitForSeconds (Random.Range(15f, 20f)); 
		}
	}

	IEnumerator generatePlanes () {
		while (true) {
			trumpshootscript = GameObject.FindObjectOfType<TrumpShoot> ().GetComponent<TrumpShoot> (); 
			trumpphysicsscript = GameObject.FindObjectOfType<TrumpPhysics> ().GetComponent<TrumpPhysics> (); 
			if (trumpshootscript.shoot && !trumpphysicsscript.trumpdead &&  trumpobject.GetComponent<Rigidbody2D> ().velocity.x > 3) {
				Instantiate (planes, new Vector2 (trumpobject.transform.position.x + 80f, Random.Range(50f,60f)), transform.rotation); 
			}
			yield return new WaitForSeconds (Random.Range(10f, 12f)); 
		}
	}
}
