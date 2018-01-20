using UnityEngine;
using System.Collections;

public class level2 : MonoBehaviour {
	public GameObject ds;
	void update () {
	ds.GetComponent<Renderer>().enabled = true;
	}

	void OnTriggerStay () {
	if (PlayerPrefs.GetInt ("unlockedlevle2", 0) == 1) {
			if(Input.GetKey("w")) {
				Application.LoadLevel("level1");
			}

			
		}
	}
	void LateUpdate () {
		if (PlayerPrefs.GetInt ("unlockedlevle2", 0) == 1) {
			ds.GetComponent<Renderer>().enabled = false;
		}
	}
}