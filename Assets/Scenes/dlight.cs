using UnityEngine;
using System.Collections;

public class dlight : MonoBehaviour {
	public GameObject a;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (PlayerPrefs.GetInt ("task2q", 0) == 1) {
			Destroy(a);

		}
	}
}
