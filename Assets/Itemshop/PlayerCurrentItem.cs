using UnityEngine;
using System.Collections;

public class PlayerCurrentItem : MonoBehaviour {

	public bool bombvest = false; 
	public bool jetpack = false; 

	private GameObject bombvestobject; 
	private GameObject jetpackobject; 

	public GunObject[] guns; 
	public int gunnumber = 0; 

	// Use this for initialization
	void Start () {
		bombvestobject = GameObject.Find ("bombvest"); 
		jetpackobject = GameObject.Find ("Jetpack"); 


		if (bombvest) {
			bombvestobject.SetActive (true); 
		} 

		if (jetpack) {
			jetpackobject.SetActive (true); 
		} 
	}
	
	// Update is called once per frame
	void Update () {
			

	}
}
