using UnityEngine;
using System.Collections;

public class shooot : MonoBehaviour {

	public GameObject bullet;
	public float speed = 5.0f;
	int a = 1;
	// Use this for initialization
	void Start () {
		a = 1;
	}

	void strali () {

		Vector2 target = Camera.main.ScreenToWorldPoint( new Vector2(Input.mousePosition.x,  Input.mousePosition.y) );
		Vector2 myPos = new Vector2(transform.position.x,transform.position.y + 2);
		Vector2 direction = target - myPos;
		direction.Normalize();
		Quaternion rotation = Quaternion.Euler( 0, 0, Mathf.Atan2 ( direction.y, direction.x ) * Mathf.Rad2Deg );
		GameObject projectile = (GameObject) Instantiate( bullet, myPos, rotation);
		projectile.GetComponent<Rigidbody>().velocity = direction * speed;
		a++;
		if (a ==3) {
			StartCoroutine(TestCoroutine());
				
		}
	}
	IEnumerator TestCoroutine(){
		yield return new WaitForSeconds(2);
		a = 1;

	}
	IEnumerator TestCoroutined(){
		yield return new WaitForSeconds(5);
		a = 1;
		
	}
	
	void Update () {
		if (Input.GetKeyDown ("r"))
		{
			StartCoroutine(TestCoroutined());

		}
		if (Input.GetMouseButtonDown (0)) {
						if (a <= 3) { 
								strali (); 
						}

				}

	
		}

	}

