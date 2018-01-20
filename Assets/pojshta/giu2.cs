using UnityEngine;
using System.Collections;

public class giu2 : MonoBehaviour {
	// Use this for initialization
	public GUIStyle men;
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnGUI () {
		GUI.Label(new Rect(100,100,100,100), "Било изпълнено с щастие",men); 
		GUI.Label(new Rect(100,100,100,100), "YES WE!");
	}
}