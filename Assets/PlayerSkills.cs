using UnityEngine;
using System.Collections;

public class PlayerSkills : MonoBehaviour {

	public int bulletcount = 0; 
	private Vector2 mouseposition; 
	public GameObject bloodsplat; 

	private TrumpPhysics trumpphysicsscript; 
	private GameObject trumpobject; 

	private PlayerCurrentItem playerguns; 
	private AudioSource clickaudio;
	// Use this for initialization
	void Start () {
		trumpphysicsscript = GameObject.FindObjectOfType<TrumpPhysics> ().GetComponent<TrumpPhysics>(); 
		playerguns = GameObject.FindObjectOfType<PlayerCurrentItem> ().GetComponent<PlayerCurrentItem> ();
		bulletcount = playerguns.guns [playerguns.gunnumber].bulletcount; 
	}
	
	// Update is called once per frame
	void Update () {
		trumpobject = GameObject.FindObjectOfType<TrumpPhysics> ().gameObject; 
			
		mouseposition = Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, +12.3f));
		if (bulletcount > 0) {
			if (Input.GetMouseButtonDown (0)) {
				
				RaycastHit2D hit = Physics2D.Raycast (mouseposition, Vector2.zero, 5f);
				if (hit.collider != null) {
					if (hit.collider.tag == "GunLayer" || hit.collider.tag == "Player") {
						bulletcount -= 1; 
						clickaudio = GetComponent<AudioSource> (); 
						clickaudio.Play (); 
						Instantiate (bloodsplat, new Vector2 (trumpobject.transform.position.x - 0.5f, trumpobject.transform.position.y - 0.1f), transform.rotation); 
						if (trumpphysicsscript.spritenumber != 2) {
							trumpphysicsscript.spritenumber += 1;
						} else {
							trumpphysicsscript.spritenumber = 0; 
						}
						Rigidbody2D trumpbody2d = hit.collider.transform.parent.GetComponent<Rigidbody2D> (); 
						trumpbody2d.AddForce (Vector2.up * playerguns.guns [playerguns.gunnumber].firepower); 
					}
				}
			}
		}

	}
}
