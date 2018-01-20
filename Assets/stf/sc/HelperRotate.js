#pragma strict
var rotate : Vector3;
function Update () {
	if(!GetComponent.<Rigidbody>())
		transform.Rotate(rotate * Time.deltaTime);
}

function FixedUpdate () {
	if(GetComponent.<Rigidbody>())
	{
		var deltaRotation : Quaternion = Quaternion.Euler(rotate * Time.deltaTime);
		GetComponent.<Rigidbody>().MoveRotation(GetComponent.<Rigidbody>().rotation * deltaRotation);
	}
}