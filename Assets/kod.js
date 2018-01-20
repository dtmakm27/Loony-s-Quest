#pragma strict
import System.IO;
import System.Diagnostics;
var kodirane;
var koda;
	var kod : TextAsset;
	var kodr : TextAsset;
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
	var hiks1 : GameObject;
	var hiks2 : GameObject;
	var hiks3 : GameObject;
	var hiks4 : GameObject;
	var hiks5 : GameObject;
	var hiks6 : GameObject;
	var hiks7 : GameObject;
	var hiks8 : GameObject;
	var hiks9 : GameObject;
public	var hiks10 : GameObject;
public var myObject :GameObject;


	function Start () {
	

		if(kod != null)
		{
			kodirane = (kod.text);	
		}
		
		if(kodr != null)
		{
			koda = (kodr.text);	
		}
	}
	function OnGUI () {
		
	
	if (GUI.Button (new Rect (100, 110, 100, 90), "Сравни")) {
			var otgovor1 = System.IO.File.ReadAllText("E:/dea n/IT shit/maxdigitc#/maxdigitc#/maxdigit.001.sol");
			var izhod1 = System.IO.File.ReadAllText("E:/dea n/IT shit/maxdigitc#/maxdigitc#/maxdigit.001.txt");
			var otgovor2 = System.IO.File.ReadAllText("E:/dea n/IT shit/maxdigitc#/maxdigitc#/maxdigit.002.sol");
			var izhod2 = System.IO.File.ReadAllText("E:/dea n/IT shit/maxdigitc#/maxdigitc#/maxdigit.002.txt");
			var otgovor3 = System.IO.File.ReadAllText("E:/dea n/IT shit/maxdigitc#/maxdigitc#/maxdigit.003.sol");
			var izhod3 = System.IO.File.ReadAllText("E:/dea n/IT shit/maxdigitc#/maxdigitc#/maxdigit.003.txt");
			var otgovor4 = System.IO.File.ReadAllText("E:/dea n/IT shit/maxdigitc#/maxdigitc#/maxdigit.004.sol");
			var izhod4 = System.IO.File.ReadAllText("E:/dea n/IT shit/maxdigitc#/maxdigitc#/maxdigit.004.txt");
			var otgovor5 = System.IO.File.ReadAllText("E:/dea n/IT shit/maxdigitc#/maxdigitc#/maxdigit.005.sol");
			var izhod5 = System.IO.File.ReadAllText("E:/dea n/IT shit/maxdigitc#/maxdigitc#/maxdigit.005.txt");
			var otgovor6 = System.IO.File.ReadAllText("E:/dea n/IT shit/maxdigitc#/maxdigitc#/maxdigit.006.sol");
			var izhod6 = System.IO.File.ReadAllText("E:/dea n/IT shit/maxdigitc#/maxdigitc#/maxdigit.006.txt");
			var otgovor7 = System.IO.File.ReadAllText("E:/dea n/IT shit/maxdigitc#/maxdigitc#/maxdigit.007.sol");
			var izhod7 = System.IO.File.ReadAllText("E:/dea n/IT shit/maxdigitc#/maxdigitc#/maxdigit.007.txt");
			var otgovor8 = System.IO.File.ReadAllText("E:/dea n/IT shit/maxdigitc#/maxdigitc#/maxdigit.008.sol");
			var izhod8 = System.IO.File.ReadAllText("E:/dea n/IT shit/maxdigitc#/maxdigitc#/maxdigit.008.txt");
			var otgovor9 = System.IO.File.ReadAllText("E:/dea n/IT shit/maxdigitc#/maxdigitc#/maxdigit.009.sol");
			var izhod9 = System.IO.File.ReadAllText("E:/dea n/IT shit/maxdigitc#/maxdigitc#/maxdigit.009.txt");
			var otgovor10 = System.IO.File.ReadAllText("E:/dea n/IT shit/maxdigitc#/maxdigitc#/maxdigit.010.sol");
			var izhod10 = System.IO.File.ReadAllText("E:/dea n/IT shit/maxdigitc#/maxdigitc#/maxdigit.010.txt");
			if(otgovor1 == izhod1)
				tik1.gameObject.SetActive(true);
			else
				hiks1.gameObject.SetActive(true);
			if(otgovor2 == izhod2)
				tik2.gameObject.SetActive(true);
			else
				hiks2.gameObject.SetActive(true);
			if (otgovor3 == izhod3)
				tik3.gameObject.SetActive(true);
			else
				hiks3.gameObject.SetActive(true);
			if(otgovor4 == izhod4)
				tik4.gameObject.SetActive(true);
			else
				hiks4.gameObject.SetActive(true);
			if(otgovor5 == izhod5)
				tik5.gameObject.SetActive(true);
			else 
				hiks5.gameObject.SetActive(true);
			if(otgovor6 == izhod6)
				tik6.gameObject.SetActive(true);
			else
				hiks6.gameObject.SetActive(true);
			if(otgovor7 == izhod7)
				tik7.gameObject.SetActive(true);
			else
				hiks7.gameObject.SetActive(true);
			if(otgovor8 == izhod8)
				tik8.gameObject.SetActive(true);
			else 
				hiks8.gameObject.SetActive(true);
			if(otgovor9 == izhod9)
				tik9.gameObject.SetActive(true);
			else
				hiks9.gameObject.SetActive(true);
			if(otgovor10 == izhod10)
				tik10.gameObject.SetActive(true);
			else
				hiks10.gameObject.SetActive(true);
				}
				

				}
	function Update () {
	if (myObject.activeSelf == true) {
	Application.LoadLevel("1");
	}
	}