using UnityEngine;
using System.Collections;

public class shirs4 : MonoBehaviour {
	void OnTriggerEnter(Collider player) {
		Destroy (this.gameObject);
		Application.LoadLevelAdditiveAsync ("shas");
		Time.timeScale = 0;
	}
}