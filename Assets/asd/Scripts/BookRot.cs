using UnityEngine;
using System.Collections;

public class BookRot : MonoBehaviour {
	
	public float speed = 300;
	
	void Update () {
		transform.Rotate(Vector3.up * speed * Time.deltaTime,Space.World);
	}
	
	
	
}
