using UnityEngine;
using System.Collections;

public class shirs5 : MonoBehaviour {
	void OnTriggerEnter(Collider player) {
		Destroy (this.gameObject);
		Application.LoadLevelAdditiveAsync ("shesti");
		Time.timeScale = 0;
	}
}