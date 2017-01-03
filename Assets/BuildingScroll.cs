using UnityEngine;
using System.Collections;

public class BuildingScroll : MonoBehaviour {

		private float scrollspeed; 
		private Vector2 savedoffset; 
		private Renderer rend; 

		private TrumpPhysics trumpphysics; 

		// Use this for initialization
		void Start () {
			rend = GetComponent<Renderer> (); 
			savedoffset = rend.sharedMaterial.GetTextureOffset ("_MainTex");

		}

		// Update is called once per frame
		void Update () {
			trumpphysics = GameObject.FindObjectOfType<TrumpPhysics> (); 


			float x = Mathf.Repeat (trumpphysics.transform.position.x * 0.001f  , 1);


			Vector2 offset = new Vector2 (x,0); 
			rend.sharedMaterial.SetTextureOffset ("_MainTex", offset) ; 
		}

		void OnDisable () {
			rend.sharedMaterial.SetTextureOffset ("_MainTex", savedoffset); 
		}

}
