using UnityEngine;
using System.Collections;

public class shirs8 : MonoBehaviour {
	void OnTriggerEnter(Collider player) {
		Destroy (this.gameObject);
		Application.LoadLevelAdditiveAsync ("vupros9");
		Time.timeScale = 0;
	}
}