using UnityEngine;
using System.Collections;

public class box : MonoBehaviour {
	string kodaji;
	public TextAsset kodji;
	// Use this for initialization
	void Start () {
		if(kodji != null)
		{
			kodaji = (kodji.text);	
		}
	}
	
	// Update is called once per frame
	void OnGUI () {
		GUI.TextField(new Rect(Screen.width/1.114f,Screen.height/3.7f,Screen.width/8f,Screen.height/1.5f), kodaji);

	}
}
