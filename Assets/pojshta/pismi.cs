using UnityEngine;
using System.Collections;

public class pismi : MonoBehaviour {
	public GameObject yay;
	private animation anotherScript;
	public GameObject yayd;
	private giu anotherScriptt;
	private pismi ad;
	private giu1 anotherScripttt;



	// Use this for initialization
	void Start () {
	}
	
	void OnTriggerStay () {
		if (Input.GetKey("w")) {
			yay.GetComponent<Renderer>().enabled = true;
			yayd.GetComponent<Renderer>().enabled = true;
			anotherScriptt = GetComponent<giu>();
			anotherScriptt.enabled = false;
			anotherScripttt = GetComponent<giu1>();
			anotherScripttt.enabled = true;
		}
	}
}
