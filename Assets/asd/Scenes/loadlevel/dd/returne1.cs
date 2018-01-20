using UnityEngine;
using System.Collections;

public class returne1 : MonoBehaviour {
	void OnTriggerStay () {
		if(Input.GetKey("w")) {
			PlayerPrefs.DeleteAll();
			Application.LoadLevel("LevelLoad");


}
	}
}