using UnityEngine;
using System.Collections;

public class TrumpShoot : MonoBehaviour {

	private Vector2 mouseposition; 
	private TrumpPhysics trumpphysicsscript;
	private Vector2 shootdirection; 
	private TrumpEnergy energybarscript;

	private PlayerCurrentGear playercurrentweapon; 

	public bool shoot = false; 

	public Texture2D crosshair; 
	private AudioSource launchsound; 

	// Use this for initialization
	void Start () {
		trumpphysicsscript = GameObject.FindObjectOfType<TrumpPhysics> ();
		energybarscript = GameObject.FindObjectOfType<TrumpEnergy> ();
		playercurrentweapon = GameObject.FindObjectOfType<PlayerCurrentGear> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (shoot) {
			Cursor.SetCursor (crosshair, Vector2.zero, CursorMode.Auto);
		}

		mouseposition = Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, +12.3f));
		shootdirection = mouseposition - (new Vector2 (transform.position.x, transform.position.y)); 

		shootdirection.Normalize ();


		if (Input.GetMouseButtonDown (0) && !shoot) {
			if (shootdirection.x < 2) {
				shootdirection = new Vector2 (2, shootdirection.y);
			}
			trumpphysicsscript.gameObject.GetComponent<Rigidbody2D> ().isKinematic = false; 
			trumpphysicsscript.trumpShootFunction (playercurrentweapon.launchers [playercurrentweapon.launchernumber].firepower * energybarscript.valueCurrent, shootdirection);
			shoot = true;
			launchsound = GetComponent<AudioSource> (); 
			launchsound.Play (); 
		}


	}
}
