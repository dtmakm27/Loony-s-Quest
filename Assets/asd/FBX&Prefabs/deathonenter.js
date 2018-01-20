#pragma strict
var d : GameObject;
var a : GameObject;

	function OnTriggerEnter (other : Collider) {
		Destroy(other.gameObject);
		d.gameObject.active = true;
		a.gameObject.active = true;

	}

function Update () {

}