 var d = 0.3;
var s = 0.4;
private var rect3: Rect;
rect3.x = (Screen.width*(1-d))/2;
rect3.y = (Screen.width*(1-s))/2;
rect3.width = 200;
rect3.height = 200;
GetComponent(gm).enabled = true;
function Update(){     
Time.timeScale = 0;
}
  function OnGUI (){
   if(GUI.Button(Rect(rect3), "КЪМ ЛЕТИЩЕТО")) {
     PlayerPrefs.SetInt("txaw", 1);
    Time.timeScale = 1.0;
    GetComponent(gm).enabled = false;
  
    }
   }
    
      //пуска времето
    //Time.timeScale = 1.0;
    //
   
  