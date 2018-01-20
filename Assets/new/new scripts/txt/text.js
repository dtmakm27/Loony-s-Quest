GetComponent(text).enabled = true;
public var m : GameObject;
function OnGUI () {
GUI.Label(Rect(15, 10, 300, 68),"q kniga");
if (GUI.Button(Rect(20,15,300,68),"natataka space")) {
m.GetComponent.<Renderer>().enabled = true;
GetComponent(text1).enabled = true;
GetComponent(text).enabled = false;
} 
}