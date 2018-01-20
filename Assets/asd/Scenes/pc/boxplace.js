#pragma strict
var guiCam : GameObject;
var targetPos : Vector3;
function Start () {

}

function Update () {
var v3Pos = Vector3(0, 0, 0.0);
transform.position = guiCam.GetComponent.<Camera>().ViewportToWorldPoint(v3Pos);
}