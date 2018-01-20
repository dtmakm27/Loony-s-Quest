using UnityEngine;
using System.Collections;

public class levelload1 : MonoBehaviour {
void OnTriggerStay(Collider player) {
		if(Input.GetKey("w")) {
			Application.LoadLevel("1");
		}
}
}