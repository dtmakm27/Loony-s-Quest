var MyString = "";
var gObjectComponent : text4;
var d : GameObject;
gObjectComponent = GameObject.Find("taxi").GetComponent( text4 );
function OnGUI(){

    var temp = "";

    for (var c : char in MyString) {

        if (c >= "0"[0] && c <= "9"[0]) {

            temp += c;

            }

        } 

   MyString = GUI.TextField(new Rect(5,5,100,100),temp,30);
}
function Update () {
 
   d.transform.Rotate(Vector3.right * Time.deltaTime*40);
    
des();


}

function des () {
var theInt : int = parseInt (MyString);
yield WaitForSeconds(theInt);
gObjectComponent.enabled = false;
}