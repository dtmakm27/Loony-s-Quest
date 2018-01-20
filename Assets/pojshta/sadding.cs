using UnityEngine;
using System.Collections;

public class sadding : MonoBehaviour {
	public GameObject yay;
	private giu1 anotherScript;
	private giu2 anotherScriptt;
	public GameObject yayd;
	public GameObject yaydd;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("l")) {
			yay.GetComponent<Renderer>().enabled = false;
			yayd.GetComponent<Renderer>().enabled = true;
			anotherScript = GetComponent<giu1>();
			anotherScript.enabled = false;
			anotherScriptt = GetComponent<giu2>();
			anotherScriptt.enabled = true;
				}
	
	}
}
