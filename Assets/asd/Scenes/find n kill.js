var enemies : GameObject[];  // now an array of gameobjects
 
function Awake()
{
    enemies = GameObject.FindGameObjectsWithTag("paddle");
}
function update () {
Destroy (gameObject.enemies);
}