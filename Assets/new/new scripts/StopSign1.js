public var m : GameObject;
var gObjectComponent : TaxiMove;
function update () {
gObjectComponent = GameObject.Find("taxi").GetComponent( TaxiMove );     
 }
	
	function OnTriggerEnter (other : Collider) {
	
yield WaitForSeconds (5);
  Application.LoadLevel("1st");
	}
