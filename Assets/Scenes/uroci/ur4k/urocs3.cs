using UnityEngine;
using System.Collections;
using System.Diagnostics;
using System.IO;
public class urocs3 : MonoBehaviour {
	public GUIStyle st1;
	public GUIStyle st2;
	public GUIStyle st3;
	string debuginfo;
	public GUIStyle st4;
	private debuge3 myLight;
	bool greshka = true;
	public Vector2 scrollview3 = Vector2.zero;
	
	

	
	public int b = 4;
	public int c = 6;
	public GameObject sdf;
	public GameObject wqr;
	public GameObject tik1;
	public GameObject tik2;
	public GameObject tik3;
	public GameObject tik4;
	public GameObject tik5;
	public GameObject tik6;
	public GameObject tik7;
	public GameObject tik8;
	public GameObject tik9;
	public GameObject tik10;
	public GameObject hiks1;
	public GameObject hiks2;
	public GameObject hiks3;
	public GameObject hiks4;
	public GameObject hiks5;
	public GameObject hiks6;
	public GameObject hiks7;
	public GameObject hiks8;
	public GameObject hiks9;
	public GameObject hiks10;
	public GameObject hint2;
	public GameObject hinta2;
	public GameObject hintat;

	public GameObject vsichko;
	public GameObject hand;
	public Texture2D d;
	public Texture2D q;
	public Texture2D s;
	public Texture2D ds;
	public Texture2D df;
	public Texture2D ds1;
	int kodajiurok = 2;
	string adfs = "urok";
	
	public float hbvalue;
	
	public Vector2 scrollview2 = Vector2.zero;
	TextAsset kodutcontent = (TextAsset)Resources.Load ("zauroci/readme", typeof(TextAsset));
	//string kd = kodutcontent;
	string kodirane;
	string koda;
	string kodaji;
	public TextAsset kod;
	public TextAsset kodr;
	public TextAsset kodji;
	public Vector2 scrollview = Vector2.zero;
	
	// Use this for initialization
	void Start () {
		myLight = GetComponent<debuge3>();

		kodirane = System.IO.File.ReadAllText (@"C:\Loony's quest\tasks\ur4\ur4.cpp");

		adfs = "urok"+kodajiurok.ToString()+".cpp";
		
		hand = GameObject.Find("screen");
		
		if(kod != null)
		{
			kodirane = (kod.text);	
		}
		
		if(kodr != null)
		{
			koda = (kodr.text);	
		}
		if(kodji != null)
		{
			kodaji = (kodji.text);	
		}
		System.IO.File.Delete(@"C:\Loony's quest\tasks\ur4\ur4.001.txt");
		System.IO.File.Delete(@"C:\Loony's quest\tasks\ur4\ur4.002.txt");
		//kodaji = System.IO.File.ReadAllText (adfs);
		
	}

	void debug () {
		GUILayout.BeginArea (new Rect (Screen.width/2.81f,Screen.height/1.5f,Screen.width/1.84f,Screen.height/5.5f));
		scrollview3=GUILayout.BeginScrollView(scrollview3);
		kodirane = GUILayout.TextArea (kodirane,st4);
		GUILayout.EndScrollView();
		GUILayout.EndArea ();
		
		
		
	}
	void Sravni () {
		if (GUI.Button (new Rect (Screen.width / 1.9f, Screen.height / 1.19f, Screen.width / 8f, Screen.height / 3f), q, st1)) {
			
			
			
			
			Process proc = null;
			try {
				string targetDir = string.Format (@"C:\Loony's quest\tasks\ur4");
				proc = new Process ();
				proc.StartInfo.WorkingDirectory = targetDir;
				proc.StartInfo.FileName = "hidecmd.vbs";
				proc.StartInfo.Arguments = string.Format ("10");
				proc.StartInfo.CreateNoWindow = false;
				proc.Start ();
				proc.WaitForExit ();
			} catch {
			}
			
			string otgovor1 = System.IO.File.ReadAllText (@"C:\Loony's quest\tasks\ur4\ur4.001.sol");
			string izhod1 = System.IO.File.ReadAllText (@"C:\Loony's quest\tasks\ur4\ur4.001.txt");
			
			if (otgovor1 == izhod1) {
				tik1.gameObject.SetActive (true);
				sdf.gameObject.SetActive (true);
			} else
				hiks1.gameObject.SetActive (true);
			
		}
	}

	void OnGUI(){ 
		
		if (tik1.activeSelf == true) {
			
			
			if(GUI.Button(new Rect(Screen.width/1.14f,Screen.height/50f,Screen.width/8f,Screen.height/4),s,st1)){
				//Application.LoadLevelAdditiveAsync("ur4");
				PlayerPrefs.SetInt ("task1chastu", 1);

				Destroy (vsichko);

				
				hand = GameObject.Find("screen");
				Destroy (hand);
			}
		}
		
		//	GUI.Box (new Rect (Screen.width/46,Screen.height/50,Screen.width/100*97,Screen.height/100*97), "");
		GUILayout.BeginArea (new Rect (Screen.width/46,Screen.height/15,Screen.width/3,Screen.height/1.2f));
		
		scrollview2=GUILayout.BeginScrollView(scrollview2);
		
		GUILayout.TextField(kodaji,st2);
		GUILayout.EndScrollView();
		GUILayout.EndArea ();
		
		
		
		
		GUILayout.BeginArea (new Rect (Screen.width/2.81f,Screen.height/15,Screen.width/1.84f,Screen.height/1.7f));
		scrollview=GUILayout.BeginScrollView(scrollview);
		kodirane = GUILayout.TextArea (kodirane,st3);
		
		GUILayout.EndScrollView();
		GUILayout.EndArea ();
		
		
		if (GUI.Button (new Rect (Screen.width/1.5f,Screen.height/1.275f,Screen.width/5f,Screen.height/3),d,st1)) {
			System.IO.File.WriteAllText (@"C:\Loony's quest\tasks\ur4\ur4.cpp", kodirane);
			System.IO.File.Delete(@"C:\Loony's quest\tasks\ur4\ur4.001.txt");
			System.IO.File.Delete(@"C:\Loony's quest\tasks\ur4\ur4.002.txt");
			//greshka = false;
			System.IO.File.Delete (@"C:\Loony's quest\tasks\ur4\a.txt");
			
			Process proc = null;
			
			try {
				string targetDir = string.Format (@"C:\Loony's quest\tasks\ur4\");
				proc = new Process ();
				proc.StartInfo.WorkingDirectory = targetDir;
				proc.StartInfo.FileName = "xc.bat";
				proc.StartInfo.Arguments = string.Format ("10");
				proc.StartInfo.CreateNoWindow = false;
				proc.Start ();
				proc.WaitForExit ();
			} catch {
			}
			
			debuginfo = System.IO.File.ReadAllText (@"C:\Loony's quest\tasks\ur4\a.txt");
			if(debuginfo.Contains("(error)")) {
				greshka = true;
			}
			else {//(error) 
				greshka = false;
			} 
			myLight.enabled = true;
			
		}
		//if (GUI.Button (new Rect (Screen.width / 5f, Screen.height / 1.18f, Screen.width / 8f, Screen.height / 3.4f), ds, st1)) {
		
		//}
		if (GUI.Button (new Rect (Screen.width / 40f, Screen.height / 1.18f, Screen.width / 8f, Screen.height / 3.4f), df, st1)){
			Application.LoadLevelAdditiveAsync("urocks3");
			Destroy(vsichko);}
		if (GUI.Button (new Rect (Screen.width / 100, Screen.height / 100, Screen.width / 14f, Screen.height / 7f), ds1, st1))
			Destroy (vsichko);
		Time.timeScale = 1;
		
		;
		if (greshka == false) {
			Sravni();
		}
		
	}
	
	/* 	try {
      Process myProcess = new Process();
       myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
       myProcess.StartInfo.CreateNoWindow = true;
       myProcess.StartInfo.UseShellExecute = false;
       myProcess.StartInfo.FileName = "C:\\Windows\\system32\\cmd.exe";
       string path = "C:\\Users\\Brian\\Desktop\\testFile.bat";
       myProcess.StartInfo.Arguments = "/c" + path;
       myProcess.EnableRaisingEvents = true;
       myProcess.Start();
       myProcess.WaitForExit();a
       int ExitCode = myProcess.ExitCode;
       //print(ExitCode);
       } catch (Exception e){
         print(e);       
       }*/
	//	System.Diagnostics.Process.Start(@"C:\Users\user\Documents\Visual Studio 2010\Projects\ludotoslonche\ludotoslonche\bin\Debug\ludotoslonche.exe");
	
	
	// Update is called once per frame

	/* 	try {
      Process myProcess = new Process();
       myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
       myProcess.StartInfo.CreateNoWindow = true;
       myProcess.StartInfo.UseShellExecute = false;
       myProcess.StartInfo.FileName = "C:\\Windows\\system32\\cmd.exe";
       string path = "C:\\Users\\Brian\\Desktop\\testFile.bat";
       myProcess.StartInfo.Arguments = "/c" + path;
       myProcess.EnableRaisingEvents = true;
       myProcess.Start();
       myProcess.WaitForExit();a
       int ExitCode = myProcess.ExitCode;
       //print(ExitCode);
       } catch (Exception e){
         print(e);       
       }*/
		//	System.Diagnostics.Process.Start(@"C:\Users\user\Documents\Visual Studio 2010\Projects\ludotoslonche\ludotoslonche\bin\Debug\ludotoslonche.exe");


	// Update is called once per frame
	void Update () {

		if (hiks1.activeSelf == true) {
			hint2.gameObject.SetActive (true);
			hinta2.gameObject.SetActive (true);
			hintat.gameObject.SetActive (true);

	}
		if (hiks2.activeSelf == true) {
			hint2.gameObject.SetActive (true);
			hinta2.gameObject.SetActive (true);
			hintat.gameObject.SetActive (true);

		}
		if (hiks3.activeSelf == true) {
			hint2.gameObject.SetActive (true);
			hinta2.gameObject.SetActive (true);
			hintat.gameObject.SetActive (true);

		}
		if (hiks4.activeSelf == true) {
			hint2.gameObject.SetActive (true);
			hinta2.gameObject.SetActive (true);
			hintat.gameObject.SetActive (true);

		}
		if (hiks5.activeSelf == true) {
			hint2.gameObject.SetActive (true);
			hinta2.gameObject.SetActive (true);
			hintat.gameObject.SetActive (true);

		}
		if (hiks6.activeSelf == true) {
			hint2.gameObject.SetActive (true);
			hinta2.gameObject.SetActive (true);
			hintat.gameObject.SetActive (true);

		}
		if (hiks7.activeSelf == true) {
			hint2.gameObject.SetActive (true);
			hinta2.gameObject.SetActive (true);
			hintat.gameObject.SetActive (true);

		}
		if (hiks8.activeSelf == true) {
			hint2.gameObject.SetActive (true);
			hinta2.gameObject.SetActive (true);
			hintat.gameObject.SetActive (true);

		}
		if (hiks9.activeSelf == true) {
			hint2.gameObject.SetActive (true);
			hinta2.gameObject.SetActive (true);
			hintat.gameObject.SetActive (true);

			
		}
		if (hiks10.activeSelf == true) {
			hint2.gameObject.SetActive (true);
			hinta2.gameObject.SetActive (true);
			hintat.gameObject.SetActive (true);

			
		}
	
}

}
