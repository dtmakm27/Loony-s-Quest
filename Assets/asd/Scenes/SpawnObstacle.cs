using UnityEngine;
using System.Collections;

public class SpawnObstacle : MonoBehaviour {
	
	public GameObject obstacle;
	float x = 3;
	
	void Update () {
		float y = Random.Range(6f, 20f);
		if(x < 500) {
			Instantiate(obstacle, new Vector3(x * 8.0f, y, 0),Quaternion.identity);
			x++;
		}
		Debug.Log(x);
	}
}