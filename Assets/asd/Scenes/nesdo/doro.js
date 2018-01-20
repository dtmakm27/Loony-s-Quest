#pragma strict
var a : GameObject;
function OnTriggerEnter () {
a.gameObject.SetActive(true);
}

function OnTriggerExit () {
a.gameObject.SetActive(false);

}
function OnTriggerStay () {
if(Input.GetKey("w")){
yield WaitForSeconds (1);
Application.LoadLevel("1");
}
}