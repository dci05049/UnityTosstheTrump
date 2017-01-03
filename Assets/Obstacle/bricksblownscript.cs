using UnityEngine;
using System.Collections;

public class bricksblownscript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D> ().AddForce(new Vector2 (Random.Range(-3,3),Random.Range(-5,5)) * Random.Range(300,400));
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (0,0,3) * Random.Range(-120,120) * Time.deltaTime);
	}
}
