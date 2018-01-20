//var GUIEnabled : boolean = false;
//var save1 : GameObject;
var en : GameObject;

      //  Instantiate(enemy);

function OnGUI () {
    if (GUI.Button (Rect (20,40,80,20), "create save")) {
       // save1.gameObject.SetActive (true);
     savek2.count++;
      savek2.heigh +=20;
               //GUIEnabled = !GUIEnabled;
               Instantiate(en);
              
               

    }
   /* if (GUIEnabled) { 
    if (GUI.Button(Rect(20,40,80,heigh),"save" + count++));
  
    }
    }
   function Update () 
   {
 
     }*/
}