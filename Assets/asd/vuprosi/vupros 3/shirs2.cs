using UnityEngine;
using System.Collections;

public class shirs2 : MonoBehaviour {
	void OnTriggerEnter(Collider player) {
		Destroy (this.gameObject);
		Application.LoadLevelAdditiveAsync ("jas");
		Time.timeScale = 0;
	}
}