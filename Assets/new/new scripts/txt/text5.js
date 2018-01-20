GetComponent(text5).enabled = true;
public var d : GameObject;
public var g : GameObject;
function OnGUI () {
GUI.Label(Rect(15, 10, 300, 68),"tva beshe qko");
if (GUI.Button(Rect(20,15,300,68),"krai")) {
d.GetComponent.<Renderer>().enabled = false;
g.GetComponent.<Renderer>().enabled = true;
GetComponent(text6).enabled = true;
GetComponent(text5).enabled = false;

} 
}