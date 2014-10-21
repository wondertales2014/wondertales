#pragma strict

var pato : GameObject;
var cisne : GameObject;
var patoSound : AudioSource;

function Start () {
		cisne.SetActive(false);
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
		patoSound.Play();
		pato.SetActive(false);
		cisne.SetActive(true);
		}
	if (valor == 2)	
		{
		
		}
	if (valor == 3)
		{
		
		}
}
