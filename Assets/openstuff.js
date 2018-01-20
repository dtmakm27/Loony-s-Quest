#pragma strict
import System.IO;
import System.Diagnostics;
function Start () {

}
 

var fileLocation: String = "E:/dea n/IT shit/maxdigit/all.bat";

var test:Process = new Process();

test.StartInfo.FileName = fileLocation;
function OnGUI () { 
if (GUI.Button(Rect(170,90,300,40),"kazanz")) {
test.Start();
	}
}
//E:/dea n/IT shit/maxdigit/all.bat