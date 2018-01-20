using UnityEngine;
using System.Collections;

public class Sawblade : MonoBehaviour {
	
	public float speed = 300;

	void Update () {
		for (var i=0; i<4; i++) {

						transform.Rotate (Vector3.up * speed * Time.deltaTime, Space.World);
				}
	}
	
	

		}

