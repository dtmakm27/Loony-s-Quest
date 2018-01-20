public var m : GameObject;
var gObjectComponent : TaxiMove;
var gObjectComponentd : gm2;
function update () {
gObjectComponentd = GameObject.Find("MainCamera").GetComponent( gm2 );  
gObjectComponent = GameObject.Find("taxi").GetComponent( TaxiMove );     
 }
	
	function OnTriggerEnter (other : Collider) {
yield WaitForSeconds (3);
Destroy(m);
	  PlayerPrefs.SetInt("spirka", 1);
  gObjectComponent.enabled = true;
  yield WaitForSeconds (9);
  Application.LoadLevel("intro1");
	}
