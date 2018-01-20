using UnityEngine;
using System.Collections;

public class ending : MonoBehaviour {
	public GameObject ds;
	void update () {
		ds.GetComponent<Renderer>().enabled = true;
	}
	
	void OnTriggerStay () {
		if (PlayerPrefs.GetInt ("end", 0) == 1) {
			if(Input.GetKey("w")) {
				Application.LoadLevel("doors");
			}
			
			
		}
	}
	void LateUpdate () {
		if (PlayerPrefs.GetInt ("end", 0) == 1) {
			ds.GetComponent<Renderer>().enabled = false;
		}
	}
}
