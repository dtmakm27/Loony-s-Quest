
public var myObject :GameObject;


function Start ()
{
    Debug.Log("Active Self: " + myObject.activeSelf);
    Debug.Log("Active in Hierarchy" + myObject.activeInHierarchy);
}

var b : GUIStyle;
function OnGUI () {
GUI.Label(Rect(80,40,100,50),"reshi mi zadachata i ta puskam,i znai che brata zima hapove",b);
if(GUI.Button(Rect(70,70,60,30),"next")){
Destroy(this.gameObject);
}
}

function Update () {

}