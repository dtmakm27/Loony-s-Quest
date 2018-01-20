#pragma strict
var hand : GameObject;
var d = true;
function Start () {
}

function OnTriggerStay () {
if (Input.GetKeyDown("w")) {
Application.LoadLevel("1st");
}
}
