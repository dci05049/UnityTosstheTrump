using UnityEngine;
using System.Collections;

public class clicktostart : MonoBehaviour {

	private bool changescene = false; 
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		
		if (Input.GetMouseButtonDown(0)) {
			if (!changescene) {
				StartCoroutine (ChangeLevel ()); 
				changescene = true; 
			}
		}
	}


	IEnumerator ChangeLevel () {
		float fadetime = GameObject.FindObjectOfType<fade> ().BeginFade(1);
		yield return new WaitForSeconds(fadetime); 
		Application.LoadLevel ("Trump");
	}
}
