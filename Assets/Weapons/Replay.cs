using UnityEngine;
using System.Collections;

public class Replay : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Time.timeScale = 1f; 
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator ChangeLevel () {
		float fadetime = GameObject.FindObjectOfType<fade> ().BeginFade(1);
		yield return new WaitForSeconds(fadetime); 
		Application.LoadLevel ("Trump");
	}

	public void levelchange () {
		StartCoroutine (ChangeLevel ()); 
	}
}
