using UnityEngine;
using System.Collections;

public class vratanivo1 : MonoBehaviour {
	public GameObject ds;
	void start () {
	}
	void update () {
		ds.GetComponent<Renderer>().enabled = true;
	}
	IEnumerator q(){
		yield return new WaitForSeconds(2);
		Application.LoadLevel("linerunner");
	}
	void OnTriggerStay () {
	
			GetComponent<dooranim1>().enabled = true;
			if(Input.GetKey("w")) {
				StartCoroutine(q());
			}
			
			
		}

	void LateUpdate () {
		if (PlayerPrefs.GetInt ("unlockedlevlev", 0) == 1) {
			ds.GetComponent<Renderer>().enabled = false;
		}
	}
}
