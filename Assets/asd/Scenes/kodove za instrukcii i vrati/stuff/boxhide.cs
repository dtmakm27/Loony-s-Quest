using UnityEngine;
using System.Collections;

public class boxhide : MonoBehaviour {
	public GameObject gg;
	void start () {
		gg.GetComponent<Renderer>().enabled = false;
		}
	void Update()
		{
		gg.GetComponent<Renderer>().enabled = false;

		


		}
		
	}
