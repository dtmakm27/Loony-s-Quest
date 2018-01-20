using UnityEngine;
using System.Collections;

public class noviqmiscriptzaubivanenaneshta : MonoBehaviour {
	public GameObject a;
	public GameObject c;
	public GameObject d;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("space")) {
			Destroy(a);
			c.gameObject.SetActive ( true);
			d.gameObject.SetActive ( true);
			Destroy(this.gameObject);
		}
	}
}
