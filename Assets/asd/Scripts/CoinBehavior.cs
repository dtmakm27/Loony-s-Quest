using UnityEngine;
using System.Collections;

public class CoinBehavior : MonoBehaviour {
	public GameObject a;
	void update () {
				a.GetComponent<Renderer>().enabled = true;
		}
	// когато се сблъска с монетата се пуска 
	void OnTriggerEnter(Collider collider)
	{
		

			
			

			CoinController.coinCount++;
			
			Destroy (this.gameObject);
			a.GetComponent<Renderer>().enabled = false;
			


		
		
	}
	
}
