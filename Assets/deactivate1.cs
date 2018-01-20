using UnityEngine;
using System.Collections;

public class deactivate1 : MonoBehaviour {
	public GameObject a;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (PlayerPrefs.GetInt ("task1c", 0) == 1) {
			Destroy(a);

				}
	}
}
