GetComponent(TaxiMoveOther).enabled = true;
var movespeed : float = 0.4f;

function Start() {
}
function Update () {
this.transform.position.x += movespeed;
}