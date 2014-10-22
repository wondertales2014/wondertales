#pragma strict

var anim : Animator;
var patos : Animator;
var crack : AudioSource;
var egg : GameObject;

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
		crack.Play();
		egg.SetActive(false);
		}
	if (valor == 2)	
		{
		anim.SetBool("break", false);
		}
	if (valor == 3)
		{
		
		}
}
