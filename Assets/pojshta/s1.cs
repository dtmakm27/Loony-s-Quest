using UnityEngine;
using System.Collections;

public class s1 : MonoBehaviour {
	public GameObject yay;
	public GameObject yayd;
	private giu3 anotherScript;
	private giu4 anotherScriptt;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("n")){
		yay.GetComponent<Renderer>().enabled = false;
			yayd.GetComponent<Renderer>().enabled = true;
			anotherScript = GetComponent<giu3>();
			anotherScript.enabled = false;
			anotherScriptt = GetComponent<giu4>();
			anotherScriptt.enabled = true;
	}
}
}