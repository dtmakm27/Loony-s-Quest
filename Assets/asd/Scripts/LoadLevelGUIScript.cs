using UnityEngine;
using System.Collections;

public class LoadLevelGUIScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI() {
				//почва GUI групата
				GUILayout.BeginArea (new Rect (Screen.width / 2 - 100, Screen.height / 2 - 100, 200, 200));
				//мюсто
				GUILayout.FlexibleSpace ();

				if (GUILayout.Button ("Load level 1")) { 
						Application.LoadLevel (2);
				}
				//ако "unlockedlevel2"(виж go2level) е равно на 1 (0 е по подразбиране) показва GUI бутона
		if (PlayerPrefs.GetInt ("unlockedlevle2", 0) == 1) {

						if (GUILayout.Button ("Load level 2")) { 
								Application.LoadLevel ("2");
						}
				}
		GUILayout.FlexibleSpace();

		GUILayout.EndArea ();

		}
	}
	
	
