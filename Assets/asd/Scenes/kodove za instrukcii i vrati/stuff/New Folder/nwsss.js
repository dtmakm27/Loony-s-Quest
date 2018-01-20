var anim : Animation;
var arm : GameObject;
arm = gameObject.FindWithTag("Door32");
 
function OnTriggerStay()   
{  if(Input.GetKey("w")) {      
     anim.Play();
     arm.GetComponent.<Animation>().Play("open");
}   
}