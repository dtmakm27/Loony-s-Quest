using UnityEngine;
using System.Collections;

public class anim : MonoBehaviour {
	private bool Open;
	private Animator animator;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();

	
		if(Input.GetKey("w")) {
			animator.SetBool("Open",true);
			

		}
	
	
	}
}