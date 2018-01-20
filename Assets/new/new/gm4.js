 var d = 0.3;
var s = 0.4;
private var rect3: Rect;
rect3.x = (Screen.width*(1-d))/2;
rect3.y = (Screen.width*(1-s))/2;
rect3.width = 150;
rect3.height = 30;
 function OnGUI (){

  GUI.Button(Rect(rect3), "Кажи на къде"); 
   }
   function Update () {
if (PlayerPrefs.GetInt ("txaw", 0) == 1) {
GetComponent(gm4).enabled = false;
}

}