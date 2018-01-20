using UnityEngine;
using System.Collections;

public class koca : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	string text = System.IO.File.ReadAllText(@"E:/dea n/maxdigit.txt");

	// Update is called once per frame
	void OnGUI () {
		if (GUI.Button (new Rect (50, 60, 70, 80), text)) {
			Application.OpenURL ((Application.dataPath) + "E:/dea n/IT shit/maxdigit/all.bat");

				}
	}
}
