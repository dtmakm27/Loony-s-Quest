#pragma strict

function Start () {

}

function OnTriggerEnter () {
yield WaitForSeconds (2);
  Application.LoadLevel("1st");
}