#pragma strict
 var hit : RaycastHit;
 var dist : float;
 var dir : Vector3;
 
 function Update(){
      dist = 10;
      dir = Vector3(0,-0.3,0);
 
      //edit: to draw ray also//
      Debug.DrawRay(transform.position,dir*dist,Color.green);
      //end edit//
 
     
      }
     
 
 
function OnTriggerEnter(other : Collider) { 
if(other.transform.tag=="Enemy")
	{
	 if(Physics.Raycast(transform.position,dir,hit,dist)){
     {
      Destroy (other.gameObject);
           //the ray collided with something, you can interact
           // with the hit object now by using hit.collider.gameObject
      }
	}

}
}