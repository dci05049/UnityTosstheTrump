using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class GameInfoScript : MonoBehaviour {

	public static GameInfoScript gameinfocontrol; 
	public float Trumpmoney; 
	public float distancetravelled; 
	public float BestDistance = 0; 
	public float TotalEarned = 0; 

	public Text moneytext; 
	public Text distance; 
	public Text moneyearnedshop; 

	public string currentlauncher; 

	// Use this for initialization
	void Start () {

		if (gameinfocontrol == null) {
			DontDestroyOnLoad (gameObject); 
			gameinfocontrol = this; 
		} else if (gameinfocontrol != this) {
			Destroy (gameObject); 
		}
	
	}
	
	// Update is called once per frame
	void Update () {
		setcountset (); 
		if (distancetravelled > BestDistance) {
			BestDistance = distancetravelled; 
		}


	}

	void setcountset () {
		moneytext.text = "Trump's Small Loan of: $" + Trumpmoney.ToString ();
		distance.text = "Distance Travelled: " + distancetravelled + "m"; 
		moneyearnedshop.text = "Total Earned: $" + TotalEarned; 
	}
}
