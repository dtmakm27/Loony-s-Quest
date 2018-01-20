using UnityEngine;
using System.Collections;

public class s : MonoBehaviour {
	public GameObject yay;
	public GameObject yayd;
	private giu2 anotherScript;
	private giu3 anotherScriptt;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("o")){
		yay.GetComponent<Renderer>().enabled = false;
			yayd.GetComponent<Renderer>().enabled = true;
			anotherScript = GetComponent<giu2>();
			anotherScript.enabled = false;
			anotherScriptt = GetComponent<giu3>();
			anotherScriptt.enabled = true;
	}
}
}