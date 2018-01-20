#pragma strict
var hand : GameObject;
var d = true;
function Start () {
hand = GameObject.Find("screen");
}

function OnTriggerEnter () {
Time.timeScale = 0;
Application.LoadLevelAdditiveAsync("taskselsect");
d = false;
}
function Update () {
if(Input.GetKeyDown("escape")){
hand = GameObject.Find("screen");
Destroy(hand);
d = true;
Time.timeScale = 1;
}
}