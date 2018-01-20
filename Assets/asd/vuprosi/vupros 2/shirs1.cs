using UnityEngine;
using System.Collections;

public class shirs1 : MonoBehaviour {
	void OnTriggerEnter(Collider player) {
		Destroy (this.gameObject);
		Application.LoadLevelAdditiveAsync ("dss");
		Time.timeScale = 0;
	}
}