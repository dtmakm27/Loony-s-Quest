using UnityEngine;
using System.Collections;

public class level3 : MonoBehaviour {
	public GameObject ds;
	void update () {
		ds.GetComponent<Renderer>().enabled = true;
	}
	
	void OnTriggerStay () {
		if (PlayerPrefs.GetInt ("unlockedlevel3", 0) == 1) {
			if(Input.GetKey("w")) {
				Application.LoadLevel("level2");
			}
			
			
		}
	}
	void LateUpdate () {
		if (PlayerPrefs.GetInt ("unlockedlevel3", 0) == 1) {
			ds.GetComponent<Renderer>().enabled = false;
		}
	}
}