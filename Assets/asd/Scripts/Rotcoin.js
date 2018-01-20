#pragma strict

 

var rotationSpeed : float = 10;  

 

private var minimumY = -360;

private var maximumY = 360;

private var rotationY : float;

private var minimumX = -360;

private var maximumX = 360;

private var rotationX : float;

 

 

function Update () {

    

    rotationX += Input.GetAxis("Vertical") * rotationSpeed;

    rotationX = ClampAngle(rotationX, minimumX, maximumX);

    

    rotationY += Input.GetAxis("Horizontal") * rotationSpeed;

    rotationY = ClampAngle(rotationY, minimumY, maximumY);

    

    transform.rotation = Quaternion.AngleAxis(rotationY, Vector3.up);

    transform.rotation *= Quaternion.AngleAxis (rotationX, Vector3.right);

}

 

static function ClampAngle (angle : float, min : float, max : float) {

   if (angle < -360)

      angle += 360;

   if (angle > 360)

      angle -= 360;

   return Mathf.Clamp (angle, min, max);

}