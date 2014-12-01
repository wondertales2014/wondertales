#pragma strict

var altura : UI.Text;
var fondo : UI.Text;
var Chimenea : GameObject;

private var posicionInicial : Vector3;

function Start () {
posicionInicial = transform.position;
}

function Update () {

for (var touch : Touch in Input.touches){
        var ray = Camera.main.ScreenPointToRay(touch.position);
        var hit : RaycastHit;
        if (Physics.Raycast (ray, hit, Mathf.Infinity)) {
            if(touch.phase == TouchPhase.Began || touch.phase == TouchPhase.Moved) {
            	altura.text = "altura: " + transform.localPosition.y;
            	fondo.text  = "fondo : " + transform.localPosition.x;
            	if (transform.localPosition.y >= 0)
            		{
            		transform.localPosition.z = 0;
            		posicionInicial.z = Chimenea.transform.position.z;
            		}
                var cameraTransform = Camera.main.transform.InverseTransformPoint(transform.position);
                transform.position = Camera.main.ScreenToWorldPoint(new Vector3 (touch.position.x, touch.position.y, cameraTransform.z));
            }
            if(touch.phase == TouchPhase.Ended) {
				if ((transform.localPosition.y >= -24 && transform.localPosition.y <= 0) &&
    				(transform.localPosition.x >= -24 && transform.localPosition.x <= 24))
    				{
    				var allChildRenderers = GetComponentsInChildren.<Renderer>();
                    for ( var R in allChildRenderers)
                    	{
                    	R.enabled = false;
                    	}           
    				this.renderer.enabled = false;
    				audio.Play();
    				}

            }

        }
    }
}

function OnTouchDown (funcion : int) {

}