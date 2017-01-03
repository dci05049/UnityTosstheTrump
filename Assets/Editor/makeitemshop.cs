using UnityEngine;
using System.Collections;
using UnityEditor; 

public class MakeLauncherObject {

	[MenuItem("Assets/Create/Weapon Object")]
	public static void Create () 
	{
		LauncherObject asset = ScriptableObject.CreateInstance<LauncherObject> (); 
		AssetDatabase.CreateAsset (asset, "Assets/NewWeaponObject.asset"); 
		AssetDatabase.SaveAssets (); 
		EditorUtility.FocusProjectWindow (); 
		Selection.activeObject = asset; 
	}
}
