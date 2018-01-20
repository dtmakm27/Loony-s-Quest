#pragma strict
var vsi4ko : GameObject;
function Start () {

}

function Update () {
if (Input.GetKeyDown("escape")) {
Destroy(vsi4ko);
}
}