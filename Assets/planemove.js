private var offsetX : float;
 
function Update () 
{
    GetComponent.<Renderer>().material.mainTextureOffset = Vector2(offsetX,0);
    offsetX -= 0.2 * Time.deltaTime;
}