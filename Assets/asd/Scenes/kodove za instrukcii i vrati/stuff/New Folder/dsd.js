var anim : Animation ;
var DoorGameObject : Transform; // This is a reference to the door GameObject that has your animation
private var HasTriggerBeenUsed : boolean = false; // This is to make sure that the button is not repeatedly pressed.
private var setTrigger : boolean = false;
function OnTriggerStay() {
   if (Input.GetKeyDown("w") && !HasTriggerBeenUsed) {
      DoorGameObject.GetComponent.<Animation>().Play("Open");
      anim.Play();
      setTrigger = true;
   }
   }