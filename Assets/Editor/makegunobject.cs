using UnityEngine;
using System.Collections;
using UnityEditor; 

public class makegunobject {

	[MenuItem("Assets/Create/Gun Object")]
	public static void Create () 
	{
		GunObject asset = ScriptableObject.CreateInstance<GunObject> (); 
		AssetDatabase.CreateAsset (asset, "Assets/NewGunObject.asset"); 
		AssetDatabase.SaveAssets (); 
		EditorUtility.FocusProjectWindow (); 
		Selection.activeObject = asset; 
	}
}
