using UnityEngine;
using System.Collections;

public class adsdasads : MonoBehaviour {
	TextMesh myText;

	// Use this for initialization
	void Start () {
		myText = GetComponent<TextMesh>();
		myText.text = "";
	}
	
	void Update() {
		foreach (char c in Input.inputString) {
			if (c == "\b"[0])
				if (GetComponent<GUIText>().text.Length != 0)
					GetComponent<GUIText>().text = GetComponent<GUIText>().text.Substring(0, GetComponent<GUIText>().text.Length - 1);
			
			else
				if (c == "\n"[0] || c == "\r"[0])
					print("User entered his name: " + GetComponent<GUIText>().text);
			else
				GetComponent<GUIText>().text += c;
		}
	}
}
