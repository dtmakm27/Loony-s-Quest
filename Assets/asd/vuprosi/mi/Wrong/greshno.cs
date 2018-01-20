using UnityEngine;
using System.Collections;

public class greshno : MonoBehaviour {
	public GameObject other;
	public GameObject another;
	public int gore = 30;
	public int dolo = 30;
	public int lqvo = 30;
	public int dqsno = 30;
	void OnGUI () {
		// Make the second button.
		if(GUI.Button(new Rect(gore,dolo,lqvo,dqsno), "Space to continue") || Input.GetKeyUp ("space")) {
			Destroy (this.gameObject);
			Destroy (other);
			Destroy (another);
			Time.timeScale = 1;
		}
	}
}