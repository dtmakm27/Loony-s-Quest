#pragma strict
// stikchetatasushtoto
	var st1: GUIStyle;

	var hiks1 : GameObject;
	var hiks2 : GameObject;
	var hiks3 : GameObject;
	var hiks4 : GameObject;
	var hiks5 : GameObject;
	var hiks6 : GameObject;
	var hiks7 : GameObject;
	var hiks8 : GameObject;
	var hiks9 : GameObject;
	var hiks10 : GameObject;
	var tik1 : GameObject;
	var tik2 : GameObject;
	var tik3 : GameObject;
	var tik4 : GameObject;
	var tik5 : GameObject;
	var tik6 : GameObject;
	var tik7 : GameObject;
	var tik8 : GameObject;
	var tik9 : GameObject;
	var tik10 : GameObject;
	var tk : Texture2D;
		var tui : GameObject;
var m = true;
	var novokompilatorche : GameObject;
	var starokompilatorchi : GameObject;
function OnGUI () {
if (GUI.Button(Rect(Screen.width/3f,Screen.height/1.11f,Screen.width/5f,Screen.height/10),tk,st1)) {
	hiks1.gameObject.SetActive(false);
	hiks2.gameObject.SetActive(false);
	hiks3.gameObject.SetActive(false);
	hiks4.gameObject.SetActive(false);
	hiks5.gameObject.SetActive(false);
	hiks6.gameObject.SetActive(false);
	hiks7.gameObject.SetActive(false);
	hiks8.gameObject.SetActive(false);
	hiks9.gameObject.SetActive(false);
	hiks10.gameObject.SetActive(false);
	tik1.gameObject.SetActive(false);
	tik2.gameObject.SetActive(false);
	tik3.gameObject.SetActive(false);
	tik4.gameObject.SetActive(false);
	tik5.gameObject.SetActive(false);
	tik6.gameObject.SetActive(false);
	tik7.gameObject.SetActive(false);
	tik8.gameObject.SetActive(false);
	tik9.gameObject.SetActive(false);
	tik10.gameObject.SetActive(false);
    
	starokompilatorchi.SetActive(false);
	novokompilatorche.gameObject.SetActive(true);
	m = false;

}
}

function Update () {
if (m == false) {
    Destroy(this.gameObject);
    }
}