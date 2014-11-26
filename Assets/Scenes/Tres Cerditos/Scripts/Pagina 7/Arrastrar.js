#pragma strict

private var camaraPos : Vector3;

function Start () {

}

function Update () {

for (var touch : Touch in Input.touches){
        var ray = Camera.main.ScreenPointToRay(touch.position);
        var hit : RaycastHit;
        if (Physics.Raycast (ray, hit, Mathf.Infinity)) {
            if(touch.phase == TouchPhase.Began || touch.phase == TouchPhase.Moved) {
            	if (transform.localPosition.y > 8.5)
            		{
            		transform.localPosition.z = 2.63; 
            		}
                var cameraTransform = Camera.main.transform.InverseTransformPoint(transform.position);
                transform.position = Camera.main.ScreenToWorldPoint(new Vector3 (touch.position.x, touch.position.y, cameraTransform.z));
            }
        }
    }
}

function OnTouchDown (funcion : int) {

}