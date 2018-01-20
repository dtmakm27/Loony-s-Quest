var buttonWidth: int = 100;
var buttonHeight: int = 50;
var spacing: int = 100;
public var other : GameObject;
public var another : GameObject;

function OnGUI () {
	GUILayout.BeginArea(Rect(Screen.width/2 - buttonWidth/2, Screen.height/2 - buttonHeight/2 - 200, buttonWidth, 400));
		if(GUILayout.Button("ne", GUILayout.Height(buttonHeight))){
			Application.LoadLevelAdditiveAsync("23");
			Destroy (this.gameObject);
	        Destroy (other);
	        Destroy (another);
		}
		GUILayout.Space(spacing);
		if(GUILayout.Button("da", GUILayout.Height(buttonHeight))) {
			Destroy (this.gameObject);
	        Destroy (other);
		}
		GUILayout.Space(spacing);
		if(GUILayout.Button("neznam", GUILayout.Height(buttonHeight))) {
			Destroy (this.gameObject);
	        Destroy (other);
		}
	GUILayout.EndArea();
	
}	