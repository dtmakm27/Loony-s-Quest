@script RequireComponent(AudioSource)

public var clip : AudioClip;

function OnTriggerEnter(hit : Collider){

GetComponent.<AudioSource>().PlayClipAtPoint(clip, Vector3 (5, 1, 2)); 
Destroy(gameObject);

}