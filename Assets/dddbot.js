var theScript;
var dmg:float = 20;
function Start () {

}
function OnCollisionEnter(col : Collision){
            if (col.gameObject.name == "Player2(Clone)") {
           transform.SendMessage("Damage",dmg);
			Destroy (col.gameObject);
            Destroy (this.gameObject);
			


                                    }
                                  
    }
     
function Update () {



       dest();
}
function dest () {
 yield WaitForSeconds(2);
		Destroy(this.gameObject);
}
