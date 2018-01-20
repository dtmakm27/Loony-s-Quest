#pragma strict
// this script is used to make a collision box for a attack for an enemy. create a collider and attach this script. then make a prefab out of it!

internal var damage : float;
internal var attacking_guy : GameObject;
internal var pushback : float;
function OnTriggerEnter(other : Collider)
{
	if(other.transform.tag=="Player")
	{
		//other.transform.gameObject.SendMessage("apply_damage",damage);
		//other.rigidbody.AddExplosionForce(pushback*2,attacking_guy.transform.position,0,3,ForceMode.Impulse);
		other.gameObject.transform.position.x = 0;
other.gameObject.transform.position.y = 1.1;
other.gameObject.transform.position.z = 0;
	}
}

function Start()
{
	GetComponent.<Renderer>().enabled=false;
}