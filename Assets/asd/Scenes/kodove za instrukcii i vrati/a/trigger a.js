var w : GameObject;
function OnTriggerEnter (other : Collider) {
Destroy (this.gameObject);
Destroy (w);
}
