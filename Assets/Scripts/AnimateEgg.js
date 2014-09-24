#pragma strict

var anim : Animator;
var patos : Animator;

function Start () {

	anim = GetComponent(Animator);
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
		anim.SetBool("break", true);
		patos.SetBool("start", true);
		}
	if (valor == 2)	
		{

		}
	if (valor == 3)
		{
		
		}
}
