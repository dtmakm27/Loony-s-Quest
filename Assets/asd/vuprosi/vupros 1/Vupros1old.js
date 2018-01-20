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
		// Register the window. Notice the 3rd parameter 
		windowRect = GUI.Window (0, windowRect, DoMyWindow, "Въпрос#1");
	}
	// Make the contents of the window
	function DoMyWindow (windowID : int) {
	
		GUILayout.BeginArea(Rect(Screen.width/2 - buttonWidth, Screen.height/2 - buttonHeight - 200, buttonWidth, 400));
		if(GUILayout.Button("Последователност от инструкции", GUILayout.Height(buttonHeight)) || Input.GetKeyUp ("z")){
			Application.LoadLevelAdditiveAsync("vqrno");
			Destroy (this.gameObject);
			Destroy (other);
			Destroy (another);
			Destroy (a);
			Destroy (b);
			Destroy (c);
			
		}
		GUILayout.Space(spacing);
		if(GUILayout.Button("Решение на задача", GUILayout.Height(buttonHeight))|| Input.GetKeyUp ("x")) {
			Application.LoadLevelAdditiveAsync("greshno");
			Destroy (this.gameObject);
			Destroy (other);
			Destroy (another);
			Destroy (a);
			Destroy (b);
			Destroy (c);
		}
		GUILayout.Space(spacing);
		if(GUILayout.Button("Блок-схема", GUILayout.Height(buttonHeight))|| Input.GetKeyUp ("c")) {
			Application.LoadLevelAdditiveAsync("greshno");
			Destroy (this.gameObject);
			Destroy (other);
			Destroy (another);
			Destroy (a);
			Destroy (b);
			Destroy (c);
		}
	GUILayout.EndArea();
	}