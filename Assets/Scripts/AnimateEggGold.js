#pragma strict

var anim : Animator;
var patos : Animator;
var crack : AudioSource;
var egg1 : GameObject;
var egg2 : GameObject;
var egg3 : GameObject;
var egg4 : GameObject;
var egg5 : GameObject;
var egg6 : GameObject;
var texto : Text;

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
		if(egg1.activeInHierarchy == false &&
		egg2.activeInHierarchy == false &&
		egg3.activeInHierarchy == false &&
		egg4.activeInHierarchy == false &&
		egg5.activeInHierarchy == false &&
		egg6.activeInHierarchy == false) {
			anim.SetBool("break", true);
			patos.SetBool("start", true);
			crack.Play();
			texto.text = "Bien hecho!";
		} else {
			texto.text = "Primero debes romper los huevos blancos!";
		}
		
		}
	if (valor == 2)	
		{
		anim.SetBool("break", false);
		}
	if (valor == 3)
		{
		
		}
}
