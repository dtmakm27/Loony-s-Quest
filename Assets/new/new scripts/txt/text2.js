GetComponent(text2).enabled = true;
public var n : GameObject;
public var b : GameObject;
function OnGUI () {
GUI.Label(Rect(15, 10, 300, 68),"kef we machina ");
if (GUI.Button(Rect(20,15,300,68),"NATATAKA")) {
n.GetComponent.<Renderer>().enabled = false;
b.GetComponent.<Renderer>().enabled = true;
GetComponent(text3).enabled = true;
GetComponent(text2).enabled = false;
} 
}