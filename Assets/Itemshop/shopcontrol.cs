using UnityEngine;
using System.Collections;

public class shopcontrol : MonoBehaviour {

	public GameObject shoppanel; 
	private TrumpPhysics trumpscript; 
	private GameInfoScript gameinfoscript; 

	public bool shopenter = false; 


	// Use this for initialization
	void Start () {
		trumpscript = GameObject.FindObjectOfType<TrumpPhysics> ().GetComponent<TrumpPhysics> (); 
	}
	
	// Update is called once per frame
	void Update () {
		if (trumpscript.trumpdead && shopenter) {
			Entershop (); 
		} else if (!trumpscript.trumpdead) {
			shoppanel.SetActive (false);
		}
	}

	void Entershop () {
		shoppanel.SetActive (true); 
	}

	public void Closeshop () {
		shoppanel.SetActive (false);
		shopenter = false; 
		gameinfoscript = GameObject.FindObjectOfType<GameInfoScript> ().GetComponent<GameInfoScript> (); 
		gameinfoscript.Trumpmoney = 0; 
		Application.LoadLevel(Application.loadedLevel);
	}
}
