using UnityEngine;
using System.Collections;

public class shirs3 : MonoBehaviour {
	void OnTriggerEnter(Collider player) {
		Destroy (this.gameObject);
		Application.LoadLevelAdditiveAsync ("qas");
		Time.timeScale = 0;
	}
}