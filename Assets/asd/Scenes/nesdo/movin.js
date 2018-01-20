private var offsetY : float;
 
function Update () 
{
    GetComponent.<Renderer>().material.mainTextureOffset = Vector3(0,-offsetY);
    offsetY -= 0.01 * Time.deltaTime;
}