var newSkin : GUISkin;
var logoTexture : Texture2D;

function thePauseMenu() {
//начало на групата от GUI буттони
    GUI.BeginGroup(Rect(Screen.width / 2 - 150, 50, 300, 250));
    //меню фона
    GUI.Box(Rect(0, 0, 300, 250), "");
    //текстура(картинка)
    GUI.Label(Rect(15, 10, 300, 68), logoTexture);
    ////МЕНЮ С БУТОНИ
    //обратно към играта бутон
    if(GUI.Button(Rect(55, 100, 180, 40), "Resume")) {
    //пуска времето
    Time.timeScale = 1.0;
    //изключва пауза менюто
    var script3 = GetComponent("pausemenu"); 
    script3.enabled = false;
    //скрива курсора
    var script4 = GetComponent("hidecursor"); 
    script4.enabled = true; 
    }
    
    if(GUI.Button(Rect(55, 150, 180, 40), "Main Menu")) {
    //връща към маин менюто
    Time.timeScale = 1.0;
    Application.LoadLevel("mainmenu2");
    }
    
    if(GUI.Button(Rect(55, 200, 180, 40), "Quit")) {
    //изключва играта
    Application.Quit();
    }
    //край на групата
    GUI.EndGroup(); 
}

function OnGUI () {
//пуска GUIskin
    GUI.skin = newSkin;
//пуска курсора
    Cursor.visible = true;
//пуска pausemenu скрипта
    thePauseMenu();
}