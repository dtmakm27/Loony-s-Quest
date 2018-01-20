GetComponent(TaxiMove).enabled = true;
var gObjectComponent ;
gObjectComponent = GameObject.Find("MainCamera").GetComponent( gm );  
var waiting = false;
var movespeed : float = 0.4f;
public var Player : Transform;

function Start() {
}
function Update () {

this.transform.position.x += movespeed;
Destroy(Player.gameObject);
gObjectComponent.enabled = true;
}


function wait () {
for(i=1;i>0;i++) {
yield WaitForSeconds(2);
waiting = false;
yield WaitForSeconds(3);
waiting = true;
}
}