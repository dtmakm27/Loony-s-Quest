var m = 0;
function Update () {
//ако се натисне esc. спира времето , спира кода за спирането на курсора и пуска pausemenu
if(Input.GetKeyDown("escape")) {
    m++;

    Time.timeScale = 0;
    var script3 = GetComponent("pausemenu"); 
    script3.enabled = true;
    //var script4 = GetComponent("hidecursor"); 
    //script4.enabled = false; 
    
    }
    if (m>=2){
    Time.timeScale = 1;
    script3.enabled = false;
    m = 0;
    }
}