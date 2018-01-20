using UnityEngine;
using System.Collections;
using System.Diagnostics;
using System.IO;
public class novokomp1 : MonoBehaviour {
	public int b = 4;
	public int c = 6;
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
	public Vector2 scrollview = Vector2.zero;


	
	string kodirane;
	string koda;
	string kodaji;
	public TextAsset kod;
	public TextAsset kodr;
	public TextAsset kodji;

	
	// Use this for initialization
	void Start () {
		
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
		if (tik1.activeSelf == true) {
			if (tik2.activeSelf == true) {
				if(tik3.activeSelf == true) {
					if(tik4.activeSelf == true) {
						if(tik5.activeSelf == true){
							if(tik6.activeSelf == true){
								if(tik7.activeSelf == true){
									if(tik8.activeSelf == true){
										if(tik9.activeSelf == true){
											if(tik10.activeSelf ==true){
												
												if(GUI.Button(new Rect(Screen.width/1.31f,Screen.height/2,Screen.width/5.6f,Screen.height/4),"Gjdavaitakawe")){
													PlayerPrefs.SetInt("task1c",1);
													Application.LoadLevel("taskselsect");

												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}
		GUI.Box (new Rect (Screen.width/46,Screen.height/50,Screen.width/100*97,Screen.height/100*97), "n");
		
		GUI.TextField(new Rect(Screen.width/46,Screen.height/50,Screen.width/1.84f,Screen.height/4), kodaji);

		GUILayout.BeginArea (new Rect (Screen.width/46,Screen.height/3.72f,Screen.width/1.84f,Screen.height/1.5f));
		scrollview=GUILayout.BeginScrollView(scrollview);
		kodirane = GUILayout.TextArea (kodirane);
		GUILayout.EndScrollView();
		GUILayout.EndArea ();
		
		
		if (GUI.Button (new Rect (Screen.width/1.31f,Screen.height/50,Screen.width/5.6f,Screen.height/4), "Kompilirai")) {
			System.IO.File.WriteAllText (@"E:\dea n\IT shit\maxdigit\maxdigit.cpp", kodirane);
						Process proc = null;
						try {
				string targetDir = string.Format (@"E:\dea n\IT shit\maxdigit");
								proc = new Process ();
								proc.StartInfo.WorkingDirectory = targetDir;
								proc.StartInfo.FileName = "hidecmd.vbs";
								proc.StartInfo.Arguments = string.Format ("10");
								proc.StartInfo.CreateNoWindow = false;
								proc.Start ();
								proc.WaitForExit ();
						} catch {
						}

				}



		
		if (GUI.Button (new Rect (Screen.width/1.773f,Screen.height/50,Screen.width/5,Screen.height/4), "Sravni")) {
			string otgovor1 = System.IO.File.ReadAllText (@"E:\dea n\IT shit\maxdigit\maxdigit.001.sol");
			string izhod1 = System.IO.File.ReadAllText (@"E:\dea n\IT shit\maxdigit\maxdigit.001.txt");
			string otgovor2 = System.IO.File.ReadAllText (@"E:\dea n\IT shit\maxdigit\maxdigit.002.sol");
			string izhod2 = System.IO.File.ReadAllText (@"E:\dea n\IT shit\maxdigit\maxdigit.002.txt");
			string otgovor3 = System.IO.File.ReadAllText (@"E:\dea n\IT shit\maxdigit\maxdigit.003.sol");
			string izhod3 = System.IO.File.ReadAllText (@"E:\dea n\IT shit\maxdigit\maxdigit.003.txt");
			string otgovor4 = System.IO.File.ReadAllText (@"E:\dea n\IT shit\maxdigit\maxdigit.004.sol");
			string izhod4 = System.IO.File.ReadAllText (@"E:\dea n\IT shit\maxdigit\maxdigit.004.txt");
			string otgovor5 = System.IO.File.ReadAllText (@"E:\dea n\IT shit\maxdigit\maxdigit.005.sol");
			string izhod5 = System.IO.File.ReadAllText (@"E:\dea n\IT shit\maxdigit\maxdigit.005.txt");
			string otgovor6 = System.IO.File.ReadAllText (@"E:\dea n\IT shit\maxdigit\maxdigit.006.sol");
			string izhod6 = System.IO.File.ReadAllText (@"E:\dea n\IT shit\maxdigit\maxdigit.006.txt");
			string otgovor7 = System.IO.File.ReadAllText (@"E:\dea n\IT shit\maxdigit\maxdigit.007.sol");
			string izhod7 = System.IO.File.ReadAllText (@"E:\dea n\IT shit\maxdigit\maxdigit.007.txt");
			string otgovor8 = System.IO.File.ReadAllText (@"E:\dea n\IT shit\maxdigit\maxdigit.008.sol");
			string izhod8 = System.IO.File.ReadAllText (@"E:\dea n\IT shit\maxdigit\maxdigit.008.txt");
			string otgovor9 = System.IO.File.ReadAllText (@"E:\dea n\IT shit\maxdigit\maxdigit.009.sol");
			string izhod9 = System.IO.File.ReadAllText (@"E:\dea n\IT shit\maxdigit\maxdigit.009.txt");
			string otgovor10 = System.IO.File.ReadAllText (@"E:\dea n\IT shit\maxdigit\maxdigit.010.sol");
			string izhod10 = System.IO.File.ReadAllText(@"E:\dea n\IT shit\maxdigit\maxdigit.010.txt");
						if (otgovor1 == izhod1)
								tik1.gameObject.SetActive (true);
						else
								hiks1.gameObject.SetActive (true);
						if (otgovor2 == izhod2)
								tik2.gameObject.SetActive (true);
						else
								hiks2.gameObject.SetActive (true);
						if (otgovor3 == izhod3)
								tik3.gameObject.SetActive (true);
						else
								hiks3.gameObject.SetActive (true);
						if (otgovor4 == izhod4)
								tik4.gameObject.SetActive (true);
						else
								hiks4.gameObject.SetActive (true);
						if (otgovor5 == izhod5)
								tik5.gameObject.SetActive (true);
						else 
								hiks5.gameObject.SetActive (true);
						if (otgovor6 == izhod6)
								tik6.gameObject.SetActive (true);
						else
								hiks6.gameObject.SetActive (true);
						if (otgovor7 == izhod7)
								tik7.gameObject.SetActive (true);
						else
								hiks7.gameObject.SetActive (true);
						if (otgovor8 == izhod8)
								tik8.gameObject.SetActive (true);
						else 
								hiks8.gameObject.SetActive (true);
						if (otgovor9 == izhod9)
								tik9.gameObject.SetActive (true);
						else
								hiks9.gameObject.SetActive (true);
						if (otgovor10 == izhod10)
								tik10.gameObject.SetActive (true);
						else
								hiks10.gameObject.SetActive (true);
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
