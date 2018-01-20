#pragma strict
var a : GameObject;
function Start () {

}

function OnTriggerEnter () {
a.gameObject.active = true;
}