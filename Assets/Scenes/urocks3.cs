using UnityEngine;
using System.Collections;
using System.Diagnostics;
using System.IO;
public class urocks3 : MonoBehaviour {
	public GUIStyle st1;
	public GUIStyle st2;
	public GUIStyle st3;

	public int b = 4;
	public int c = 6;
	public GameObject fo;

	public GameObject vsichko;
	public GameObject hand;
	public Texture2D d;
	public Texture2D q;
	public Texture2D s;
	public Texture2D ds;
	public Texture2D df;
	public Texture2D ds1;


	public float hbvalue;

	public Vector2 scrollview2 = Vector2.zero;

	
	string kodirane;
	string koda;
	string kodaji;
	public TextAsset kod;
	public TextAsset kodr;
	public TextAsset kodji;
	public Vector2 scrollview = Vector2.zero;
	
	// Use this for initialization
	void Start () {

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
	}

	void OnGUI(){ 		
										
	//	GUI.Box (new Rect (Screen.width/46,Screen.height/50,Screen.width/100*97,Screen.height/100*97), "");
		GUILayout.BeginArea (new Rect (Screen.width/46,Screen.height/15,Screen.width/3,Screen.height/1.2f));

		scrollview2=GUILayout.BeginScrollView(scrollview2);

		GUILayout.TextField(kodaji,st2);
		GUILayout.EndScrollView();
		GUILayout.EndArea ();




		GUILayout.BeginArea (new Rect (Screen.width/2.81f,Screen.height/15,Screen.width/1.84f,Screen.height/1.196f));
		scrollview=GUILayout.BeginScrollView(scrollview);
				kodirane = GUILayout.TextArea (kodirane,st3);

		GUILayout.EndScrollView();
				GUILayout.EndArea ();
		
		
		if (GUI.Button (new Rect (Screen.width/1.5f,Screen.height/1.275f,Screen.width/5f,Screen.height/3),d,st1)) {

		}
		//if (GUI.Button (new Rect (Screen.width / 5f, Screen.height / 1.18f, Screen.width / 8f, Screen.height / 3.4f), ds, st1))
		//				;
		if (GUI.Button (new Rect (Screen.width / 40f, Screen.height / 1.18f, Screen.width / 8f, Screen.height / 3.4f), df, st1)) {
			Application.LoadLevelAdditiveAsync("urocks2");
			Destroy(vsichko);}
		if (GUI.Button (new Rect (Screen.width / 100, Screen.height / 100, Screen.width / 14f, Screen.height / 7f), ds1, st1))
						Destroy (vsichko);
		Time.timeScale = 1;

			;

		
		if (GUI.Button (new Rect (Screen.width/1.9f,Screen.height/1.19f,Screen.width/8f,Screen.height/3f), q,st1)) {
			fo.gameObject.SetActive (true);
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
	void Update () {

}
}