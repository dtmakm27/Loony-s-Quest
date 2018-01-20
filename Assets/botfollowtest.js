var Speed= 10;
var x : Vector3;
var Range= 18;
 
function Start(){
   Wander();
}
 
function Update() 
{
transform.position.z = 0;
transform.rotation.z = 0;
      transform.position += transform.TransformDirection(Vector3.forward)*Speed*Time.deltaTime;
    if((transform.position - x).magnitude < 3)
    {
        Wander();

 
    }
}
 
function Wander()
{  
    x =  Vector3(Random.Range(transform.position.x - Range, transform.position.x + Range),1);
    x.y = 1;
    transform.LookAt(x);
    }