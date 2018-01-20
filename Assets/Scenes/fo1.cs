using UnityEngine;
using System.Collections;

public class fo1 : MonoBehaviour {
	public GUIStyle st2;
	public Texture2D q;
	public GameObject q2;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnGUI () {
		if (GUI.Button (new Rect (Screen.width / 5f, Screen.height / 1.14f, Screen.width / 8f, Screen.height / 3.4f), q, st2)) {
			Application.LoadLevelAdditiveAsync("Task1");

			Destroy (q2);
		}
	}
}
