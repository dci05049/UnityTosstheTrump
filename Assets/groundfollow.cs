using UnityEngine;
using System.Collections;

public class groundfollow : MonoBehaviour {
	private Transform trumpposition; 
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		trumpposition = GameObject.Find ("Trump").transform; 
		transform.position = new Vector3 (trumpposition.position.x, transform.position.y, transform.position.z); 
	}
}
