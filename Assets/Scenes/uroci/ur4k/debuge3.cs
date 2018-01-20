using UnityEngine;
using System.Collections;

public class debuge3 : MonoBehaviour {
	public GUIStyle st4;
	
	string kodirane;
	string adfs = "urok";
	public Vector2 scrollview3 = Vector2.zero;
	
	
	string debuginfo;
	
	// Use this for initialization
	void Update () {
		
		kodirane = System.IO.File.ReadAllText (@"C:\Loony's quest\tasks\ur4\a.txt");
		
		
	}
	void dag() {
		GUILayout.BeginArea (new Rect (Screen.width/2.81f,Screen.height/1.5f,Screen.width/1.84f,Screen.height/5.5f));
		scrollview3=GUILayout.BeginScrollView(scrollview3);
		kodirane = GUILayout.TextArea (kodirane,st4);
		GUILayout.EndScrollView();
		GUILayout.EndArea ();
		
	}
	// Update is called once per frame
	void OnGUI () {
		dag ();
		
		
	}
}








