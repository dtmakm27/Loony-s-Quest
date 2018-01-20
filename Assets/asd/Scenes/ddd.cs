using UnityEngine;
using System.Collections;

public class ddd : MonoBehaviour {

	void OnTriggerEnter () { 

		PlayerPrefs.SetInt ("end", 1);
		}
}
