using UnityEngine;
using System.Collections;

public class s2 : MonoBehaviour {
	public GameObject yay;
	public GameObject yayd;
	private giu4 anotherScriptt;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("i")){
		yay.GetComponent<Renderer>().enabled = false;
			yayd.GetComponent<Renderer>().enabled = false;
			anotherScriptt = GetComponent<giu4>();
			anotherScriptt.enabled = false;
	}
}
}