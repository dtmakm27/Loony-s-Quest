using UnityEngine;
using System.Collections;

public class izkluchiigra : MonoBehaviour {
	public GameObject a ;

	// Use this for initialization
	void Start () {
	
	}
	void OnTriggerEnter () {
		a.gameObject.SetActive(true);
	}
	void OnTriggerExit () {
		a.gameObject.SetActive(false);
	}
	IEnumerator q(){
		yield return new WaitForSeconds(2);
		Application.Quit();
	}
	// Update is called once per frame
	void OnTriggerStay () {
		if (Input.GetKey ("w")) {
			StartCoroutine(q());

		}
	}
}
