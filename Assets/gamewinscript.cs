using UnityEngine;
using System.Collections;

public class gamewinscript : MonoBehaviour {
	private TrumpPhysics trumpscript; 
	private float timer = 0; 
	private bool changescene = false; 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		trumpscript = GameObject.FindObjectOfType<TrumpPhysics> ().GetComponent<TrumpPhysics> (); 
		if (trumpscript.brokewall) {
			if (!changescene) {
				StartCoroutine (ChangeLevel ()); 
				changescene = true; 
			}
		}
	}


	IEnumerator ChangeLevel () {
		float fadetime = GameObject.FindObjectOfType<fade> ().BeginFade(1);
		yield return new WaitForSeconds(fadetime); 
		Application.LoadLevel ("gameover");
	}
}
