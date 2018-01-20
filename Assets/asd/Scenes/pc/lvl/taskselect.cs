using UnityEngine;
using System.Collections;

public class taskselect : MonoBehaviour {
	public GameObject sichko;


	// Use this for initialization
	void OnGUI () {
				//GUI.Box ( new Rect (Screen.width / 46, Screen.height / 50, Screen.width / 100 * 97, Screen.height / 100 * 97), "");
		if (PlayerPrefs.GetInt ("task111c", 0) == 1) {

						if (GUI.Button (new Rect (Screen.width / 35, Screen.height / 50, Screen.width / 5.6f, Screen.height / 4), "Task1")) {
								Destroy (sichko);
								Application.LoadLevelAdditiveAsync ("Task1");
			
						}
				}
		if (PlayerPrefs.GetInt ("task1c", 0) == 1) {
			if(GUI.Button(new Rect (Screen.width / 4.6f, Screen.height / 50, Screen.width / 5.6f, Screen.height / 4), "Task2")) {
				Application.LoadLevelAdditiveAsync("Task3");
				Destroy(sichko);
			}
				}
		if (PlayerPrefs.GetInt ("task2c", 0) == 1) {
			if (GUI.Button(new Rect(Screen.width / 2.4f, Screen.height / 50, Screen.width / 5.6f, Screen.height / 4), "Task2")){
				Application.LoadLevelAdditiveAsync("Task2");
				Destroy(sichko);

			}
				}
			if (GUI.Button(new Rect(Screen.width / 1.4f, Screen.height / 1.6f, Screen.width / 5.6f, Screen.height / 4), "Изтрий запазени данни")){
			PlayerPrefs.DeleteAll();				
		}
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("escape")) {
			Destroy(sichko);
				}
	}
}
		