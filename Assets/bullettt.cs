using UnityEngine;
using System.Collections;

public class bullettt : MonoBehaviour {

	void OnCollisonEnter (Collider col) {

						Destroy (this.gameObject);
				
		}
}