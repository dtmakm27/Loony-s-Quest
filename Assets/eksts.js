#pragma strict
var a : GameObject;
var b : GUIStyle;
function OnGUI () {
GUI.Label(Rect(80,40,100,50),"zdr, az sum zliqt bratna petko,Acho,toi me zatvori v koda i sq az zatvorih teb(shot na taq igra i tqq antagonist)",b);
if(GUI.Button(Rect(70,70,60,30),"next")){
a.gameObject.SetActive(true);
Destroy(this.gameObject);
}
}
