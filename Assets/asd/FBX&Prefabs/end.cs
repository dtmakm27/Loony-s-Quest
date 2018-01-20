using UnityEngine;
using System.Collections;

public class end : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (CoinController.coinCount >= 12) {
			Application.LoadLevel("sc");
				}
	}
}
