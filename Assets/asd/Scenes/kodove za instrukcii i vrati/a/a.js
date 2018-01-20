var me : GUIStyle;
var q = 0.1;
var e = 0.2;
private var rect2 : Rect;
rect2.x = Screen.width*(1-q)/2;
rect2.h = Screen.height*(1-e)/2;
rect2.width = Screen.width*q;
rect2.height = Screen.height*e;
function OnGUI () {
	GUI.Label (Rect (rect2), "Натиснете А за ляво",me);
	}
