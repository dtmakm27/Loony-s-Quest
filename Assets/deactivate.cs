using UnityEngine;
using System.Collections;

public class deactivate : MonoBehaviour {
	public GameObject a;
	public GameObject b;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (PlayerPrefs.GetInt ("task111c", 0) == 1) {
			Destroy(a);
			Destroy(b);
				}
	}
}
