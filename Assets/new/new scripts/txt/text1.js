GetComponent(text1).enabled = true;
public var m : GameObject;
public var n : GameObject;
function OnGUI () {
GUI.Label(Rect(15, 10, 300, 68),"izglejda qko");
if (GUI.Button(Rect(20,15,300,68),"NATATAKA")) {
m.GetComponent.<Renderer>().enabled = false;
n.GetComponent.<Renderer>().enabled = true;
GetComponent(text2).enabled = true;
GetComponent(text1).enabled = false;
} 
}