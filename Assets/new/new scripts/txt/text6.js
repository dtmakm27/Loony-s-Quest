GetComponent(text6).enabled = true;
public var g : GameObject;
public var d : GameObject;
function OnGUI () {
GUI.Label(Rect(15, 10, 300, 68),"tva beshe qko  ");
if (GUI.Button(Rect(20,15,300,68),"kraisda")) {
g.GetComponent.<Renderer>().enabled = false;
d.GetComponent.<Renderer>().enabled = true;
//GetComponent(text7).enabled = true;
GetComponent(text6).enabled = false;

} 
}