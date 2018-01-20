using UnityEngine;
using System.Collections;

public class testaata : MonoBehaviour {
	public GUIStyle style;
	
	void OnGUI () {
		// Assign the skin to be the one currently used.

		// Make a button. This will get the default "button" style from the skin assigned to mySkin.
		GUI.Button (new Rect (10,20,500,500), "Skinned Button",style);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}


// Now create any Controls you like, and they will be displayed with the custom Skin

// You can change or remove the skin for some Controls but not others
