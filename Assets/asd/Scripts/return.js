function OnMouseEnter(){
//променя се цветът
GetComponent.<Renderer>().material.color=Color.red;
}

function OnMouseExit(){
//връща се цветът
GetComponent.<Renderer>().material.color=Color.white;
}

function OnMouseUp(){
//връща към main menu
Application.LoadLevel(0);
}
function Update(){
//връща към main menu ако се натисне Esc.
if (Input.GetKey(KeyCode.Escape)) { Application.LoadLevel(1);
}
}