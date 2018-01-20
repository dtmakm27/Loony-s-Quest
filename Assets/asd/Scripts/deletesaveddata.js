function OnMouseEnter(){
//change text color
GetComponent.<Renderer>().material.color=Color.blue;
}

function OnMouseExit(){
//change text color
GetComponent.<Renderer>().material.color=Color.red;
}

function OnMouseUp(){
//изтрива сеифа
PlayerPrefs.DeleteAll();
}