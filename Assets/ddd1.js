var theScript;
var dmg:float = 20;
function Start () {

}
function OnCollisionEnter(col : Collision){
            if (col.gameObject.name == "Player2(Clone)") {
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
