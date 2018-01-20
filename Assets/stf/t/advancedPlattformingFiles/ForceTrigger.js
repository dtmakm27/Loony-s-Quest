var power : float = 5;

function OnTriggerStay(collisionInfo : Collider)
{
	    if(collisionInfo.GetComponent.<Rigidbody>())
	    {
				collisionInfo.GetComponent.<Rigidbody>().AddForce(transform.TransformDirection (Vector3.up)*power);
	    }
}
