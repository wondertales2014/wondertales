#pragma strict

var grass : GameObject;

function Start () {

	
}

function Update () {

	var fwd = transform.TransformDirection (Vector3.forward);
	var hit:RaycastHit;
	if (Physics.Raycast (transform.position, fwd, hit, Mathf.Infinity)) 
		{

		}
}

function OnTouchDown (valor : int) {
	
	if (valor == 1)	
		{
		grass.SetActive(false);
		}
	if (valor == 2)	
		{
		}
	if (valor == 3)
		{
		
		}
}
