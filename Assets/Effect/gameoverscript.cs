using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class gameoverscript : MonoBehaviour {

	private Animator anim; 
	private TrumpPhysics trumpphysicsscript; 
	public Text distance; 
	public Text bestdistance; 
	public Text totalearned; 
	public Text Earned; 
	private bool distancemoney = false; 

	private GameInfoScript gameinfo; 
	// Use this for initialization
	void Start () {
		anim = GameObject.Find ("gameoverscreen").GetComponent<Animator> (); 

	}
	
	// Update is called once per frame
	void Update () {
		gameinfo = GameObject.FindObjectOfType<GameInfoScript> ().GetComponent<GameInfoScript> (); 
		trumpphysicsscript = GameObject.FindObjectOfType<TrumpPhysics> ().GetComponent<TrumpPhysics> (); 
		if (trumpphysicsscript.trumpdead) {
			anim.SetTrigger ("gameend"); 
			distance.text =  "Distance: " + gameinfo.distancetravelled; 
			bestdistance.text =  "Best Distance: " + gameinfo.BestDistance; 
			totalearned.text = "Total Earned: " + gameinfo.TotalEarned; 
			Earned.text = "$ Earned: " + gameinfo.Trumpmoney; 
			if (!distancemoney) {
				gameinfo.TotalEarned += gameinfo.distancetravelled * 0.25f; 
				gameinfo.Trumpmoney += gameinfo.distancetravelled * 0.25f;
				distancemoney = true; 
			}
		}
	}
}
