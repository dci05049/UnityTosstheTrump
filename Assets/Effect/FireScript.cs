using UnityEngine;
using System.Collections;

public class FireScript : MonoBehaviour {
	private JetPack jetpackscript; 
	private SpriteRenderer spriterenderer; 
	// Use this for initialization
	void Start () {
		spriterenderer = GetComponent<SpriteRenderer> (); 
	}
	
	// Update is called once per frame
	void Update () {
		
		jetpackscript = GameObject.FindObjectOfType<JetPack> (); 
		if (jetpackscript.usedjetpack) {
			spriterenderer.enabled = true; 
		} else {
			spriterenderer.enabled = false; 
		}
	}
}
