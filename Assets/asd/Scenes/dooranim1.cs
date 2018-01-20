using UnityEngine;
using System.Collections;

public class dooranim1 : MonoBehaviour {
	private float animationSpeed;
	private bool Open;
	private Animator door;
	// Use this for initialization
	void Start () {
		door = GetComponent<Animator>();
		door.SetLayerWeight(1,1);
	}
	
	// Update is called once per frame
	void Update () {
	



}
	void OnTriggerStay () {
		if (Open) {
			Open = false;
			door.SetBool("Open",false);
		}
		if (Input.GetKey("w")) {
			Open = true;
			door.SetBool("Open",true);
		}

	}
}