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
                var cameraTransform = Camera.main.transform.InverseTransformPoint(0, 0, 0);
                transform.position = Camera.main.ScreenToWorldPoint(new Vector3 (touch.position.x, touch.position.y, cameraTransform.z));
            }
        }
    }
}

function OnTouchDown (funcion : int) {

}