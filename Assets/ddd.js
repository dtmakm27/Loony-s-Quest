var direction = 1;

var bounce : float = 3;
var speed : float = 3;
var damage : float = 2;
private var lifespan : float = 2.5;
function OnCollisionStay(collisionInfo : Collision)
{
	if(collisionInfo.transform.tag!="Projectile")
	{
	    for (var contact : ContactPoint in collisionInfo.contacts) {
				if(transform.position.y-contact.point.y<0.8)
				{
					GetComponent.<Rigidbody>().velocity.y=bounce;
				}
				if(transform.position.x-contact.point.x<-0.3)
				{
					direction=-1;
				}
				if(transform.position.x-contact.point.x>0.3)
				{
					direction=1;
				}
	    }
	}
if(collisionInfo.transform.tag=="Enemy")
    {
    	collisionInfo.transform.SendMessage("apply_damage", damage);
    	Destroy(gameObject);
    }
}


function Update () {
     dest  ();
}


function dest () {
 yield WaitForSeconds(2);
		Destroy(this.gameObject);
}
