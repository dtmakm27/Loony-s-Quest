using UnityEngine;
using System.Collections;

public class shirs : MonoBehaviour {
	void OnTriggerEnter(Collider player) {
		Destroy (this.gameObject);
		Application.LoadLevelAdditiveAsync ("dwe");
		Time.timeScale = 0;
	}
}