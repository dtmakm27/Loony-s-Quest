var gObjectComponent : vurt;
var d : GameObject;
gObjectComponent = GameObject.Find("dabnite-ni").GetComponent( vurt );  
function Update() {


		d.transform.Rotate(Vector3.right * Time.deltaTime*40);
    
des();


}
function des () { 
yield WaitForSeconds(9);
gObjectComponent.enabled = false;
}