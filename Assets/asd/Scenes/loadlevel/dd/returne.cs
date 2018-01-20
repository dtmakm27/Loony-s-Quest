using UnityEngine;
using System.Collections;

public class returne : MonoBehaviour {
	void OnTriggerStay () {
		if(Input.GetKey("w")) {
			Application.LoadLevel(1);

}
	}
}