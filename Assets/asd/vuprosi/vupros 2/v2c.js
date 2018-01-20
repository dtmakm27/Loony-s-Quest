var me :GUIStyle;
var w = 0.3; // proportional width (0..1)
var h = 0.2; // proportional height (0..1)
private var rect: Rect;
rect.x = (Screen.width*(1-w))/2;
rect.y = (Screen.height*(1-h))/2;
rect.width = Screen.width*w;
rect.height = Screen.height*h;

	function OnGUI () {
		GUI.Label(rect,"Натиснете C за:",me);
}