#pragma strict

function OnTriggerStay () {
if(Input.GetKeyDown("w")){
Application.LoadLevelAdditiveAsync("cup");
Time.timeScale = 0;
}
}

function Update () {
if (Input.GetKeyDown("escape")){
Time.timeScale = 1;
}
}