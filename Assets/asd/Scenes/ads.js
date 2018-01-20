var buttonWidth: int = 100;
var buttonHeight: int = 50;
var spacing: int = 100;
var windowRect : Rect = Rect (Screen.width, Screen.height,200,700);
public var other : GameObject;
public var another : GameObject;
public var a : GameObject;
public var b : GameObject;
public var c : GameObject;
	function OnGUI () {

	
		GUILayout.BeginArea(Rect(Screen.width/2 - buttonWidth, Screen.height/2 - buttonHeight - 200, buttonWidth, 400));
		if(GUILayout.Button("Return", GUILayout.Height(buttonHeight))|| Input.GetKey(KeyCode.Escape)){
			Application.LoadLevel(0);
			}
			GUILayout.EndArea();
			}