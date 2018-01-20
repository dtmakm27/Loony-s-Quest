GetComponent(text3).enabled = true;
public var b : GameObject;
public var d : GameObject;
function OnGUI () {
GUI.Label(Rect(15, 10, 300, 68),"kef we machina ");
if (GUI.Button(Rect(20,15,300,68),"NATATAKA")) {
b.GetComponent.<Renderer>().enabled = false;
d.GetComponent.<Renderer>().enabled = true;
GetComponent(text5).enabled = true;
GetComponent(text3).enabled = false;
} 
}