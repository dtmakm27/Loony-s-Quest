using UnityEngine;
using System.Collections;

public class GameCamera : MonoBehaviour {
	
	public Transform target;
	public float trackSpeed = 25;
	
	

	public void SetTarget(Transform t) {
		target = t;
	}
	

	void LateUpdate() {
		if (target) {
			float x = IncrementTowards(transform.position.x, target.position.x , trackSpeed);
			float y = IncrementTowards(transform.position.y, target.position.y + 6, trackSpeed);
			transform.position = new Vector3(x,y, transform.position.z);
		}
	}
	

	private float IncrementTowards(float n, float target, float a) {
		if (n == target) {
			return n;	
		}
		else {
			float dir = Mathf.Sign(target - n); 
			n += a * Time.deltaTime * dir;
			return (dir == Mathf.Sign(target-n))? n: target; 
		}
	}
}
