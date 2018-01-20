var gObjectComponent : text;
GetComponent(abook).enabled = true;
gObjectComponent = GameObject.Find("taxi").GetComponent( text );     
function Start () {

}

function Update () {
if(Input.GetKey("space")) {
GetComponent(abook).enabled = false;
gObjectComponent.enabled = true;
}
}
