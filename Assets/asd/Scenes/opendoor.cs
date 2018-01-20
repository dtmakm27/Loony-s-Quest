using UnityEngine;
using System.Collections;

public class opendoor : MonoBehaviour {

	private float animationSpeed;
	private bool Opener;
	private Animator doorop;
	// Use this for initialization
	void Start () {
		doorop = GetComponent<Animator>();
		doorop.SetLayerWeight(1,1);
	}
	
	// Update is called once per frame
	void Update () {
		if (Opener) {
			Opener = false;
			doorop.SetBool("Open",false);
		}
		
		if (Input.GetKey("w")) {
			Opener = true;
			doorop.SetBool("Open",true);
		}
		
	}
}
