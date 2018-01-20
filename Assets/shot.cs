using UnityEngine;


public class shot : MonoBehaviour
{
	void OnTriggerEnter()
	{

		Destroy(this.gameObject);
	}
}