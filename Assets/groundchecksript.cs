using UnityEngine;
using System.Collections;

public class groundchecksript : MonoBehaviour {

	private Transform Trumptransform; 

	// Use this for initialization
	void Start () {
		Trumptransform = GameObject.Find ("Trump").transform; 
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector2 (Trumptransform.position.x, Trumptransform.position.y - 1);
	
	}
}
