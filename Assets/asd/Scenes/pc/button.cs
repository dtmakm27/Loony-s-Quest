using UnityEngine;
using System.Collections;

public class button : MonoBehaviour {
	public Texture2D neskin;
	public GameObject d ;
	public new Rect rect;

	// Use this for initialization
	void OnGUI () {
		GUI.Label (new Rect (Screen.width / 46, Screen.height / 50, Screen.width /10, Screen.height / 10),new GUIContent(neskin, "neskin"));
		string hover = GUI.tooltip;	
		if (hover == "neskin") {
			Debug.Log("fa sadfiasd imfasdj fiasdjfijadijf");
				}
	}
	
	// Update is called once per frame
	void OnMouseEnter () { 

	}
}
