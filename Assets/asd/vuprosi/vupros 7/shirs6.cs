using UnityEngine;
using System.Collections;

public class shirs6 : MonoBehaviour {
	void OnTriggerEnter(Collider player) {
		Destroy (this.gameObject);
		Application.LoadLevelAdditiveAsync ("vupros7");
		Time.timeScale = 0;
	}
}