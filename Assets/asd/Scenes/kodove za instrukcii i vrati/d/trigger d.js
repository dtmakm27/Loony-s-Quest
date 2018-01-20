var w : GameObject;
function OnTriggerEnter(other : Collider) {
Destroy (w);
Destroy (this.gameObject);
}

