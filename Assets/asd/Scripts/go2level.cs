using UnityEngine;
using System.Collections;

public class go2level : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	

	void Update () {
		//ако се съберът 100 монети включва 2 ниво
		if (CoinController.coinCount >= 100) {
			PlayerPrefs.SetInt("unlockedlevle2", 1);
			PlayerPrefs.SetInt("unlockedlevlev",1);
				}
	
	}
}
