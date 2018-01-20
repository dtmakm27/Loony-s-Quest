var d = 0;
var health:float = 90;
 
function Damage(dmg:float){
health -= dmg;
}
 
function Update (){
if(health <=0){
 Destroy(this.gameObject);
}
}
