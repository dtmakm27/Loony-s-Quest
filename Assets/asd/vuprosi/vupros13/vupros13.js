var buttonWidth: int = 100;
var buttonHeight: int = 50;
var qba = 0.5;
private var spacing = Screen.height/4.5*qba;
var w = 0.3; // proportional width (0..1)
var h = 0.2; // proportional height (0..1)
var i = 0.4;
var n = 0.3;
var m = 50;
var q = 100;
var d = 0.3;
var s = 0.4;
var omruzna = 0.5;
var mi = 0.3;
private var rect3: Rect;
rect3.x = (Screen.width*(1-d))/2;
rect3.y = (Screen.width*(1-s))/2;
rect3.width = Screen.width*d;
rect3.height = Screen.width*s;
private var rect2: Rect;
rect2.x = (Screen.width*(1-i))/2;
rect2.y = (Screen.height*(1-n))/2;
rect2.width =Screen.width*omruzna;
rect2.height = Screen.height*mi;
private var rect: Rect;
rect.x = (Screen.width*(1-w))/2;
rect.y = (Screen.height*(1-h))/2;
rect.width = Screen.width*w;
rect.height = Screen.height*h;
public var other : GameObject;
public var another : GameObject;
public var a : GameObject;
public var b : GameObject;
public var c : GameObject;
var men: GUIStyle;
	function OnGUI () {
		// Register the window. Notice the 3rd parameter 
		windowRect = GUI.Window (0,rect,DoMyWindow, "Въпрос#12");
	}
	// Make the contents of the window
	function DoMyWindow (windowID : int) {
	GUI.Label(rect3,"С long long създаваме:",men);
	
		GUILayout.BeginArea(Rect(rect2));
		if(GUILayout.Button("функция", GUILayout.Height(buttonHeight)) || Input.GetKeyUp ("z")){
			Application.LoadLevelAdditiveAsync("greshno");
			Destroy (this.gameObject);	
			Destroy (other);
			Destroy (another);
			Destroy (a);
			Destroy (b);
			Destroy (c);
		}
		GUILayout.Space(spacing);
		if(GUILayout.Button("масив", GUILayout.Height(buttonHeight))|| Input.GetKeyUp ("x")) {
			Application.LoadLevelAdditiveAsync("greshno");
			Destroy (this.gameObject);
			Destroy (other);
			Destroy (another);
			Destroy (a);
			Destroy (b);
			Destroy (c);
		}
		GUILayout.Space(spacing);
		if(GUILayout.Button("променлива от тип цяло числои", GUILayout.Height(buttonHeight))|| Input.GetKeyUp ("c")) {
		Application.LoadLevelAdditiveAsync("vqrno");
			Destroy (this.gameObject);
			Destroy (other);
			Destroy (another);
			Destroy (a);
			Destroy (b);
			Destroy (c);
		}
	GUILayout.EndArea();
	}