using UnityEngine;
using System.Collections;

public class giu4 : MonoBehaviour {
	// Use this for initialization
	public GUIStyle men;
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnGUI () {
		GUI.Label(new Rect(100,100,100,100), "Това е разкъзът за ЕПИЧНИТЕ му приключения",men); 
	}
}