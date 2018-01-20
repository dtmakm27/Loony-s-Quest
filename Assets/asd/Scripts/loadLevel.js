function OnMouseEnter(){
//променя се цветът
GetComponent.<Renderer>().material.color=Color.red;
}

function OnMouseExit(){
//връща се цветът
GetComponent.<Renderer>().material.color=Color.white;
}
//връща към main menu
function OnMouseUp () {
Application.LoadLevel("LevelLoad");
}
