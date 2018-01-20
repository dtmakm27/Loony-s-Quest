using UnityEngine;
using System.Collections;

public class shirs7 : MonoBehaviour {
	void OnTriggerEnter(Collider player) {
		Destroy (this.gameObject);
		Application.LoadLevelAdditiveAsync ("vupros8");
		Time.timeScale = 0;
	}
}