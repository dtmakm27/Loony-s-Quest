using UnityEngine;
using System.Collections;

public class Try_Again : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnGUI () {
		if(GUI.Button(new Rect(Screen.width/2,Screen.height/1.5f,Screen.width/5,Screen.height/10), "Try Again")){
			CoinController.coinCount= 0;
			Application.LoadLevel("linerunner 1");
		}
	}
	void Update () {
		if (Input.GetKeyUp("space"))
		{
			CoinController.coinCount= 0;
			Application.LoadLevel("linerunner 1");
		}
	}
}
