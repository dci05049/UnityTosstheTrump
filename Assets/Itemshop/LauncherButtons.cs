using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class LauncherButtons : MonoBehaviour {

	private PlayerCurrentGear playercurrentscript; 
	private PlayerCurrentItem playeruccrentitem; 
	private shopcontrol shopcontrolscript; 
	private GameInfoScript gameinfoscript; 
	private AudioSource clickaudio; 

	public int price;
	public bool purchased; 
	public int itemlaunchnum; 
	public int gunnumber; 
	public GameObject purchasedmark;  

	private AudioSource audio; 

	// Use this for initialization
	void Start () {
		
		playeruccrentitem = GameObject.FindObjectOfType<PlayerCurrentItem> ().GetComponent<PlayerCurrentItem> (); 
		playercurrentscript = GameObject.FindObjectOfType<PlayerCurrentGear> ().GetComponent<PlayerCurrentGear> (); 
		shopcontrolscript = GameObject.FindObjectOfType<shopcontrol> ().GetComponent<shopcontrol> (); 
		purchasedmark.SetActive (false); 
	}
	
	// Update is called once per frame
	void Update () {
		gameinfoscript = GameObject.FindObjectOfType<GameInfoScript> ().GetComponent<GameInfoScript> (); 
		if (purchased) {
			purchasedmark.SetActive (true); 
		}
	}

	public void OnClick () {
		if (gameinfoscript.TotalEarned >= price) {
			clickaudio = transform.parent.GetComponent<AudioSource> (); 
			clickaudio.Play (); 
			playercurrentscript.launchernumber = itemlaunchnum;
			gameinfoscript.TotalEarned -= price; 
			price = 0; 
			purchased = true; 
		}
	}

	public void OnClickJetPack () {
		if (gameinfoscript.TotalEarned >= price) {
			clickaudio = transform.parent.GetComponent<AudioSource> (); 
			clickaudio.Play (); 
			playeruccrentitem.jetpack = true; 
			gameinfoscript.TotalEarned -= price; 
			price = 0; 
			purchased = true; 
		}
	}

	public void OnCLickVest () {
		if (gameinfoscript.TotalEarned >= price) {
			clickaudio = transform.parent.GetComponent<AudioSource> (); 
			clickaudio.Play (); 
			playeruccrentitem.bombvest = true;
			gameinfoscript.TotalEarned -= price; 
			price = 0; 
			purchased = true; 
		}
	}

	public void OnClickGuns () {
		if (gameinfoscript.TotalEarned >= price) {
			clickaudio = transform.parent.GetComponent<AudioSource> (); 
			clickaudio.Play (); 
			playeruccrentitem.gunnumber = gunnumber;
			gameinfoscript.TotalEarned -= price; 
			price = 0; 
			purchased = true; 
		}
	}

	public void OnClickShop () {
		clickaudio = transform.parent.GetComponent<AudioSource> (); 
		clickaudio.Play (); 
		shopcontrolscript.shopenter = true; 
	}

	public void mutebutton () {


		audio = GameObject.Find("sound").GetComponent<AudioSource> (); 
		if (audio.mute)
			audio.mute = false;
		else
			audio.mute = true;
	}
}
