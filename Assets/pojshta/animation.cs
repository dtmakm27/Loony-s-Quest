using UnityEngine;
using System.Collections;

public class animation : MonoBehaviour {
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
		if (Open) {
			Open = false;
			door.SetBool("Happy",false);
		}
		
		if (Input.GetKey("l")) {
			Open = true;
			door.SetBool("Happy",true);
		}
		
	}
}