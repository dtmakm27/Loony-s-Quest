using UnityEngine;
using System.Collections;

public class giu1 : MonoBehaviour {
	// Use this for initialization
	public GUIStyle men;
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnGUI () {
		GUI.Label(new Rect(100,100,100,100), "В пощата намерило покана за състезание по информатика",men); 

	}
}